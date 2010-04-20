﻿/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 20/04/2010
 * Time: 10:00
 */
#region Question
/*
The sequence of triangle numbers is generated by adding the natural numbers.
So the 7^(th) triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28.
The first ten terms would be:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

Let us list the factors of the first seven triangle numbers:

     1: 1
     3: 1,3
     6: 1,2,3,6
    10: 1,2,5,10
    15: 1,3,5,15
    21: 1,3,7,21
    28: 1,2,4,7,14,28

We can see that 28 is the first triangle number to have over five divisors.

What is the value of the first triangle number to have over five hundred divisors?
*/
#endregion

using System;
using NumberTheory;

namespace euler012
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 1000000000; i++)
            {
                int t_num = Sequences.TriangleNumber(i);
                int[] divisors = Factorisation.divisors(t_num);
                if (divisors.Length > 500)
                {
                    Console.Out.WriteLine("Tri num: {0}", t_num);
                    break;
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}