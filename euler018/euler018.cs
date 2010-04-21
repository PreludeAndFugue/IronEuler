/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 21/04/2010
 * Time: 15:28
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace euler018
{
    class Program
    {
        static string file = @"euler018.txt";
        
        public static void Main(string[] args)
        {
            Data data = new Data(file);
            data.processRows();

            Console.Out.WriteLine("Answer: {0}", data.getAnswer());
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
    
    class Data : List<List<int>>
    {
        public Data(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line = "";
            
            while ((line = sr.ReadLine()) != null)
            {
                string[] values = line.Split(' ');
                List<int> row = new List<int>();
                for (int i = 0; i < values.Length; i++)
                {
                    row.Add(int.Parse(values[i]));
                }
                this.Add(row);
            }
            this.Reverse();
        }
        
        public void processRows()
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                List<int> current_row = this[i];
                List<int> next_row = this[i + 1];
                for (int j = 0; j < current_row.Count - 1; j++)
                {
                    int max = current_row[j] > current_row[j + 1] ? current_row[j] : current_row[j + 1];
                    next_row[j] = next_row[j] + max;
                }
            }
        }
        
        public int getAnswer()
        {
            return this[this.Count - 1][0];
        }
    }
}