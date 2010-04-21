/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 20/04/2010
 * Time: 15:23
 */
 
/*
 * Create an array int[1000] to store digits then do manual
 * multiplication by 2, 1000 times, calculating the digits of the 
 * array.
 */
 
using System;
using System.Collections.Generic;

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
        
        public static void Main1(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(1);
            for (int i = 0; i < 1000; i++)
            {
                number = LongMultiplication(number, 2);
                //Console.Out.WriteLine(ListToString(number));
            }
            
            number.Reverse();
            Console.Out.WriteLine(number.ToString());
            //Console.Out.WriteLine(ListToString(number));
            Console.Out.WriteLine("Answer: {0}", sumDigits(number));
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static List<int> LongMultiplication(List<int> number, int multiple)
        {
            int tens = 0;
            List<int> answer = new List<int>();
            foreach (int n in number)
            {
                int new_n = n*multiple + tens;
                tens = new_n/10;
                int new_n_unit = new_n%10;
                answer.Add(new_n_unit);
            }
            while (tens != 0)
            {
                answer.Add(tens%10);
                tens /= 10;
            }
            //answer.Reverse();
            return answer;
        }
        
        public static string ListToString(List<int> number)
        {
            string answer = "";
            foreach (int n in number)
            {
                answer += n.ToString();
            }
            return answer;
        }
        
        public static int sumDigits(List<int> number)
        {
            int answer = 0;
            foreach (int i in number)
            {
                answer += i;
            }
            return answer;
        }
    }
    
    class ListNumber : List<int>
    {
        public ListNumber()
        {}
        
        public ListNumber(int n)
        {
            while (n != 0)
            {
                this.Add(n%10);
                n /= 10;
            }
        }
        
        public ListNumber(List<int> number)
        {
            this.AddRange(number);
        }
        
        public static ListNumber operator *(ListNumber number, int multiple)
        {
            int tens = 0;
            ListNumber answer = new ListNumber();
            foreach (int n in number)
            {
                int new_n = n*multiple + tens;
                tens = new_n/10;
                int new_n_unit = new_n%10;
                answer.Add(new_n_unit);
            }
            while (tens != 0)
            {
                answer.Add(tens%10);
                tens /= 10;
            }
            //answer.Reverse();
            return answer;
        }
        
        public int DigitSum()
        {
            int answer = 0;
            foreach (int i in this)
            {
                answer += i;
            }
            return answer;
        }
        
        public override string ToString()
        {
            string answer = "";
            
            foreach (int i in this)
            {
                answer = i.ToString() + answer;
            }
            return answer;
        }
    }
}