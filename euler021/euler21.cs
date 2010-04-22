/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 09:33
 */
using System;
using System.Collections.Generic;
using NumberTheory;

namespace euler021
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> div_sums = createSumList();
            List<int> pairs = findPairs(div_sums);
            
            //Console.WriteLine("220: {0}, 284: {1}", div_sums[220], div_sums[284]);
            
            int answer = 0;
            foreach (int i in pairs)
            {
                answer += i;
            }
            
            Console.WriteLine("Answer: {0}", answer);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static List<int> findPairs(List<int> div_sums)
        {
            List<int> pairs = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                int sum_i = div_sums[i];
                if ((sum_i < 10000) && (sum_i != i) && (div_sums[sum_i] == i) && !pairs.Contains(i))
                {
                    pairs.Add(i);
                    pairs.Add(sum_i);
                }
            }
            return pairs;
        }
        
        public static List<int> createSumList()
        {
            List<int> div_sums = new List<int>();
            div_sums.Add(0); // 0
            div_sums.Add(0); // 1
            div_sums.Add(0); // 2
            div_sums.Add(0); // 3
            for (int i = 4; i < 10000; i++)
            {
                int[] pdivs = Factorisation.ProperDivisors(i);
                int pdivs_sum = div_sum(pdivs);
                div_sums.Add(pdivs_sum);
                
            }
            return div_sums;
        }
        
        public static int div_sum(int[] pdivs)
        {
            int result = 0;
            foreach (int i in pdivs)
            {
                result += i;
            }
            return result;
        }
    }
}