/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 20/04/2010
 * Time: 11:19
 */
 
 #region Question
 /* Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
  */
 #endregion
 
using System;
using System.Collections;
using System.IO;

namespace euler013
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            
            string file_name = @"euler013.txt";
            long answer = 0;
            // A list containing ten digit numbers
            ArrayList nums = getNumbers(file_name);
            Console.Out.WriteLine(nums.Count);
            
            foreach (long num in nums)
            {
                answer += num;    
            }
            
            Console.WriteLine("Answer: {0}", answer.ToString().Substring(0, 10));
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        private static ArrayList getNumbers(string file_name)
        {
            ArrayList results = new ArrayList();
            StreamReader data = new StreamReader(file_name);
            string line;
            while ((line = data.ReadLine()) != null)
            {
                long num = long.Parse(line.Substring(0, 12));
                results.Add(num);
            }
            return results;
        }
    }
}