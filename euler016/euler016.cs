/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 20/04/2010
 * Time: 15:23
 */
 
using System;
using System.Collections.Generic;

using NumberTypes;

namespace euler016
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListNumber n = new ListNumber(1);
            for (int i = 0; i < 1000; i++)
            {
                n = n*2;
                //Console.Out.WriteLine(n);
            }
            
            Console.Out.WriteLine(n);
            Console.Out.WriteLine("Answer: {0}", n.DigitSum());
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
