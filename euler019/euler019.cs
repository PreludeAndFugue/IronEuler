/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 21/04/2010
 * Time: 16:19
 */
using System;

namespace euler019
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime d = new DateTime(1901, 1, 1);
            int answer = 0;
            while (d.Year < 2001)
            {
                if (d.DayOfWeek == DayOfWeek.Sunday)
                {
                    answer++;
                }
                d = d.AddMonths(1);
            }
            
            Console.WriteLine("Answer: {0}", answer);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}