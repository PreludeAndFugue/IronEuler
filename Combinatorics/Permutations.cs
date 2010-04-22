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
        public static List<int> getPermutation(List<int> items, int perm_number)
        {
            // n should be less than len!
            List<int> answer = new List<int>();
            while (items.Count > 1)
            {
                int index = getIndex(items.Count - 1, perm_number);
                answer.Add(items[index]);
                items.Remove(index);
                perm_number -= index*Sequences.Factorial(items.Count - 1);
            }
            answer.Add(items[0]);
            return answer;
        }
        
        private static int getIndex(int len, int perm_number)
        {
            int fac = Sequences.Factorial(len);
            int index = 0;
            perm_number -= fac;
            while (perm_number > 0)
            {
                perm_number -= fac;
                index += 1;
            }
            return index - 1;
        }
        
        public static List<char> getPermutation(List<char> items, int n)
        {
            List<char> answer = new List<char>();
            
            return answer;
        }
        
        public static List<string> getPermutations(List<string> items, int n)
        {
            List<string> answer = new List<string>();
            
            return answer;
        }
    }
}