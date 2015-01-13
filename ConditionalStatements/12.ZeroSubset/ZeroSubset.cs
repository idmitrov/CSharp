/*
    We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    Assume that repeating the same subset several times is not a problem. 
 */

using System;

class ZeroSubset
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()),
           b = int.Parse(Console.ReadLine()),
           c = int.Parse(Console.ReadLine()),
           d = int.Parse(Console.ReadLine()),
           e = int.Parse(Console.ReadLine());

        bool noZeroSubs = true,
             eachInputIsZero = a == 0 && b == 0 && c == 0 && d == 0 && e == 0,
            //5 DIGITS
             abcde_found = a + b + c + d + e == 0,//ABCDE
            //4 DIGIT
             abcd_found = a + b + c + d == 0,//ABCD
             bcde_found = b + c + d + e == 0,//BCDE
             cdea_found = c + d + e + a == 0,//CDEA
             deab_found = d + e + a + b == 0,//DEAB
             eabc_found = e + a + b + c == 0,//EABC
            //3 DIGIT
             abc_found = a + b + c == 0,//ABC
             abd_found = a + b + d == 0,//ABD
             abe_found = a + b + e == 0,//ABE
             bcd_found = b + c + d == 0,//BCD
             bce_found = b + c + e == 0,//BCE
             bde_found = b + d + e == 0,//BDE
             cde_found = c + d + e == 0,//CDE
             cea_found = c + e + a == 0,//CEA
             ceb_found = c + e + b == 0,//CEB
             dea_found = d + e + a == 0,//DEA
            //2 DIGITS
             ab_found = a + b == 0,//AB
             ac_found = a + c == 0,//AC
             ad_found = a + d == 0,//AD
             ae_found = a + e == 0,//AE
             bc_found = b + c == 0,//BC
             bd_found = b + d == 0,//BD
             be_found = b + e == 0,//BE
             cd_found = c + d == 0,//CD
             ce_found = c + e == 0,//CE
             de_found = d + e == 0;//DE

        if (eachInputIsZero)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
        }
        else
        {
            //5 DIGITS CHECK
            if (abcde_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
                noZeroSubs = false;
            }
            //4 DIGITS CHECK
            if (abcd_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                noZeroSubs = false;
            }
            if (bcde_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
                noZeroSubs = false;
            }
            if (cdea_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", c, d, e, a);
                noZeroSubs = false;
            }
            if (deab_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", d, e, a, b);
                noZeroSubs = false;
            }
            if (eabc_found)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, a, b, c);
                noZeroSubs = false;
            }
            //3 DIGITS CHECK
            if (abc_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                noZeroSubs = false;
            }
            if (abd_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                noZeroSubs = false;
            }
            if (abe_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                noZeroSubs = false;
            }
            if (bcd_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                noZeroSubs = false;
            }
            if (bce_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                noZeroSubs = false;
            }
            if (bde_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                noZeroSubs = false;
            }
            if (cde_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                noZeroSubs = false;
            }
            if (cea_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, e, a);
                noZeroSubs = false;
            }
            if (ceb_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", c, e, b);
                noZeroSubs = false;
            }
            if (dea_found)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", d, e, a);
                noZeroSubs = false;
            }
            //2 DIGITS
            if (ab_found)
            {
                Console.WriteLine("{0} + {1} = 0", a, b);
                noZeroSubs = false;
            }
            if (ac_found)
            {
                Console.WriteLine("{0} + {1} = 0", a, c);
                noZeroSubs = false;
            }
            if (ad_found)
            {
                Console.WriteLine("{0} + {1} = 0", a, d);
                noZeroSubs = false;
            }
            if (ae_found)
            {
                Console.WriteLine("{0} + {1} = 0", a, e);
                noZeroSubs = false;
            }
            if (bc_found)
            {
                Console.WriteLine("{0} + {1} = 0", b, c);
                noZeroSubs = false;
            }
            if (bd_found)
            {
                Console.WriteLine("{0} + {1} = 0", b, d);
                noZeroSubs = false;
            }
            if (be_found)
            {
                Console.WriteLine("{0} + {1} = 0", b, e);
                noZeroSubs = false;
            }
            if (cd_found)
            {
                Console.WriteLine("{0} + {1} = 0", c, d);
                noZeroSubs = false;
            }
            if (ce_found)
            {
                Console.WriteLine("{0} + {1} = 0", c, e);
                noZeroSubs = false;
            }
            if (de_found)
            {
                Console.WriteLine("{0} + {1} = 0", d, e);
                noZeroSubs = false;
            }
            if (noZeroSubs == true)
            {
                Console.WriteLine("No zero subset");
            }
        }
    }
}
