/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 20/04/2010
 * Time: 14:03
 */
 
 #region Question
 /*
  * Starting in the top left corner of a 2×2 grid, there are 6 routes
  * (without backtracking) to the bottom right corner.
  * 
  * How many routes are there through a 20×20 grid?
  * */
 
 /* grid of solutions for small numbers
  * 
  *     |   0   1   2   3   4   5    
  * ------------------------------------------------------
  *   0 |   0   1   2   3   4   5
  *   1 |   1   2   3   4   5
  *   2 |   2   3   6   10
  *   3 |   3   4   10  20
  *   4 |   4   5
  *   5 |   5
  *     |
  * 
  */
 #endregion

// TODO: number 15 not solved.
 
using System;

namespace euler015
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Use a recursive solution
             * f(m, n) = f(m-1, n) + f(m, n-1)
             * f(m, 0) = m
             * f(0, n) = n
             */
            long result = StepCounter(20, 20);
            
            Console.Out.WriteLine("Answer: {0}", result);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static long StepCounter(int m, int n)
        {
            if (m == 0)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return StepCounter(m - 1, n) + StepCounter(m, n - 1);
            }
        }
    }
}