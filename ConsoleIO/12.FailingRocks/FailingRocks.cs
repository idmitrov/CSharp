/*
    Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system.
 */

using System;
using System.Collections.Generic;
using System.Threading;

class FailingRocks
{
    //GAME MESSAGES
    static void printMsg(int x, int y, string msg, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(msg);
    }
    //COLOR
    static Random RandomGenerator = new Random();
    static ConsoleColor RandomColor()
    {
        var consoleColor = Enum.GetValues(typeof(ConsoleColor));
        return (ConsoleColor)consoleColor.GetValue(RandomGenerator.Next(consoleColor.Length));
    }
    //Print DWARF ON POSITION
    //PRINT ON POSITION
    static void PrintDwarf(int x, int y, char symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(symbol);
    }
    static void PrintOnPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = RandomColor();
        Console.Write(symbol);
    }
    //CLIENT OBJECT
    struct clientObject
    {
        public int x;
        public int y;
        public char symbol;
        public ConsoleColor color;
    }

    //MAIN METHOD
    static void Main()
    {
        //PLAY FIELD WIDTH
        int playField = 30,
            lifes = 3;
        bool gameOver = false;
        //CONSOLE SIZE
        Console.BufferHeight = Console.WindowHeight = playField - playField / 5;
        Console.BufferWidth = Console.WindowWidth = playField + 20;
        //DWARF PROPERTIES
        clientObject dwarf = new clientObject();
        dwarf.x = playField / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.symbol = '0';
        dwarf.color = ConsoleColor.White;
        //CREATING LIST OF OBJECTS (ROCKS)
        List<clientObject> rocksList = new List<clientObject>();
        //GAME START
        while (gameOver == false)
        {
            //ROCKS
            clientObject newRock = new clientObject();
            newRock.color = ConsoleColor.Yellow;
            newRock.x = RandomGenerator.Next(0, playField);
            newRock.y = 0;
            newRock.symbol = '#';
            //ADDING ROCK INTO ROCKS LIST
            rocksList.Add(newRock);
            //IS PRESSED KEY ?
            if (Console.KeyAvailable)
            { //PRESSED KEY == ?
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //CLEARING KEYS FROM BUFFER
                while (Console.KeyAvailable) Console.ReadKey(true);
                //PRESSED LEFT ARROW
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {   //MOVE TO THE LEFT
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                //PRESSED RIGHT ARROW
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {   //MOVE TO THE RIGHT
                    if (dwarf.x < playField - 1)
                    {
                        dwarf.x++;
                    }
                }
            }
            //NEW ROCK LIST
            List<clientObject> rockList2 = new List<clientObject>();
            //MOVING ROCKS
            for (int i = 0; i < rocksList.Count; i++)
            {
                clientObject rockNotMoved = rocksList[i];
                clientObject rockMovedDown = new clientObject();
                rockMovedDown.x = rockNotMoved.x;
                rockMovedDown.y = rockNotMoved.y + 1;
                rockMovedDown.symbol = rockNotMoved.symbol;
                rockMovedDown.color = rockNotMoved.color;
                //IF ROCK BREAK DWARF
                if (rockMovedDown.y == dwarf.y && rockMovedDown.x == dwarf.x)
                {   //LIFES HAS NOT EXPIRED
                    if (lifes > 1)
                    {
                        lifes--;
                        printMsg(15, 0, lifes + " LIFE(S) LEFT", ConsoleColor.Red);
                        ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    }
                    else
                    //ELSE NO LIFES LEFT
                    {
                        printMsg(7, 0, "GAME OVER, PRESS ENTER TO TRY AGAIN", ConsoleColor.Red);
                        ConsoleKeyInfo pressedKey = Console.ReadKey();
                        //IF ENTER PRESSED GAME RESTARTING
                        if (pressedKey.Key == ConsoleKey.Enter)
                        {
                            lifes = 3;
                            break;
                        }
                        //ELSE GAME QUIT
                        else
                        {
                            gameOver = true;
                        }
                        break;
                    }
                }
                if (rockMovedDown.y < Console.WindowHeight)
                {
                    rockList2.Add(rockMovedDown);
                }
            }
            rocksList = rockList2;
            //CONSOLE CLEAR
            Console.Clear();
            //PRINT DWARF
            PrintDwarf(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);
            //DRAWING ROCKS FROM ROCKS LIST
            foreach (clientObject rock in rocksList)
            {
                PrintOnPosition(rock.x, rock.y, rock.symbol);
            }
            //SLEEP
            Thread.Sleep(150);
            /*TO DO...
             * ADD SCORE
             * ADD BONUS
             * CHANGE ROCK SYMBOL TO RANDOM
             * ADD SPEED
             * ADD LEVEL
             */
        }
        printMsg(0, 0, "THANK YOU FOR PLAYING!", ConsoleColor.Green);
    }
}