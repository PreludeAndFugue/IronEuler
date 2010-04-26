/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 26/04/2010
 * Time: 11:47
 */
using System;

namespace euler030
{
    class Program
    {
        public static void Main(string[] args)
        {
            int answer = 0;
            for (int i = 2; i < 1000000; i++)
            {
                if (Pow5DigitSum(i) == i)
                    answer += i;
            }
            
            Console.WriteLine("Answer: {0}", answer);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static int Pow5DigitSum(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += (int)Math.Pow(n%10, 5);
                n /= 10;
            }
            return answer;
        }
    }
}