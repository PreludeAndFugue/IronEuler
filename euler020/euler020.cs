/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 21/04/2010
 * Time: 16:40
 */
using System;
using NumberTypes;

namespace euler020
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListNumber n = new ListNumber(1);
            
            for (int i = 2; i < 101; i++)
            {
                n = n*i;
            }
            
            Console.WriteLine("Answer: {0}", n.DigitSum());
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}