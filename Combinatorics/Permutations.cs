/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 14:37
 */
using System;
using System.Collections.Generic;
using NumberTheory;

namespace Combinatorics
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    public class Permutations
    {
        
        private int[] items;
        
        public Permutations(int[] input)
        {
            items = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                items[i] = i;
        }
        
        public int[] nextPerm()
        {
            
        }
        
        public static List<int> getPermutation(List<int> items, int perm_number)
        {
        	// TODO: check that perm_number is less than items.Count!

        	// the algorithm works with zero based permutation numbering system
        	// zeroth permutation is, for example, {0 1 2 3}.
        	perm_number -= 1;
            List<int> answer = new List<int>();

            while ((items.Count > 1) && (perm_number > 0))
            {
            	int fac_len = Sequences.Factorial(items.Count - 1);
                int index = perm_number/fac_len;
                answer.Add(items[index]);
                items.RemoveAt(index);
                perm_number -= index*fac_len;
            }
            foreach(int i in items)
            {
            	answer.Add(i);
            }
            return answer;
        }

        public static List<char> getPermutation(List<char> items, int n)
        {
            List<char> answer = new List<char>();

            return answer;
        }
    }
}