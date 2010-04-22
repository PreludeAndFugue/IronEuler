/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 15:58
 */
using System;
using System.Collections.Generic;
using Combinatorics;

namespace euler024
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> seq = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            List<int> perm = Permutations.getPermutation(seq, 1000000);
            
            string answer = "";
            foreach (int i in perm)
            {
            	answer += i.ToString();
            }
            
            Console.WriteLine("Answer {0}", answer);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}