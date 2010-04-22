/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 12:38
 */
using System;
using System.Collections.Generic;
using NumberTheory;

namespace euler023
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] abundants = getAbundantNumbers();
            HashSet<int> a_sums = getAbundantSums(abundants);
            int[] numbers = getNumbers(a_sums);
            int sum = getSum(numbers);
            
            Console.WriteLine("Answer: {0}", sum);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static int[] getAbundantNumbers()
        {
            List<int> _abundantNumbers = new List<int>();
            for (int i = 12; i < 28123; i++)
            {
                if (Factorisation.isAbundantNumber(i))
                {
                    _abundantNumbers.Add(i);
                }
            }
            return _abundantNumbers.ToArray();
        }
        
        public static HashSet<int> getAbundantSums(int[] abundants)
        {
            HashSet<int> a_sums = new HashSet<int>();
            foreach (int i in abundants)
            {
                foreach (int j in abundants)
                {
                    if (i + j > 28123)
                    {
                        break;
                    }
                    a_sums.Add(i + j);
                }
            }
            return a_sums;
        }
        
        public static int[] getNumbers(HashSet<int> a_sums)
        {
            List<int> results = new List<int>();
            for (int i = 1; i < 28123; i++)
            {
                if (!a_sums.Contains(i))
                {
                    results.Add(i);
                }
            }
            return results.ToArray();
        }
        
        public static int getSum(int[] numbers)
        {
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }
    }
}