/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 10:50
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace euler022
{
    class Program
    {
        
        static string file = @"names.txt";
        
        public static void Main(string[] args)
        {
            int total_score = 0;
            string[] names = getNames();
            
            Console.WriteLine("Test colin: {0}", nameScore("COLIN", 938));
            
            for (int i = 0; i < names.Length; i++)
            {
                total_score += nameScore(names[i], i + 1);
            }
            
            Console.WriteLine("Answer: {0}", total_score);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        
        public static string[] getNames()
        {
            StreamReader data = new StreamReader(file);
            string[] names = data.ReadToEnd().Split(',');
            Array.Sort(names);            
            return names;
        }
        
        public static int nameScore(string name, int index)
        {
            int score = 0;
            name = name.Trim('"');
            foreach (char c in name.ToCharArray())
            {
                score += c - 'A' + 1;
            }
            score *= index;
            return score;
        }
    }
}