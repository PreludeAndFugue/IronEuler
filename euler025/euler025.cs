/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 23/04/2010
 * Time: 12:22
 */
using System;
using NumberTypes;

namespace euler025
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListNumber n1 = new ListNumber(1);
            ListNumber n2 = new ListNumber(1);
            int counter = 2;
            
            while (true)
            {
                ListNumber temp = n2;
                n2 = n2 + n1;
                counter += 1;
                n1 = temp;
                
                //Console.WriteLine(n2);
                if (n2.Count > 4)
                    break; 
            }
            
            Console.WriteLine(counter);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}