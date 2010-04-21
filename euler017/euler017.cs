/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 21/04/2010
 * Time: 12:36
 */
using System;
using System.Collections.Generic;

namespace euler017
{
    class Program
    {
        public static void Main(string[] args)
        {
            IntToLetterCount d = new IntToLetterCount();
            int answer = 0;
            for (int i = 1; i < 1001; i++)
            {
                Console.Out.WriteLine("{0}: {1}", i, d.CountLetters(i));
                answer += d.CountLetters(i);
            }
            
            Console.Out.WriteLine("Answer: {0}", answer);
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
    
    
    class IntToLetterCount : Dictionary<int, int>
    {
        public IntToLetterCount()
        {
            this[0] = 0;
            this[1] = 3;
            this[2] = 3;
            this[3] = 5;
            this[4] = 4;
            this[5] = 4;
            this[6] = 3;
            this[7] = 5;
            this[8] = 5;
            this[9] = 4;
            this[10] = 3;
            this[11] = 6;
            this[12] = 6;
            this[13] = 8;
            this[14] = 8;
            this[15] = 7;
            this[16] = 7;
            this[17] = 9;
            this[18] = 8;
            this[19] = 8;
            this[20] = 6;
            this[30] = 6;
            this[40] = 5;
            this[50] = 5;
            this[60] = 5;
            this[70] = 7;
            this[80] = 6;
            this[90] = 6;
        }
        
        // Return the number of letters in the number.
        public int CountLetters(int n)
        {
            int answer = 0;
            if ((n%100 >= 10) && (n%100 <= 19))
            {
                // contains 10 to 19
                answer += this[n%100];
            }
            else
            {
                // units
                answer += this[n%10];
                // tens
                answer += this[((n/10)%10)*10];
            }
            // hundreds
            if ((n/100)%10 != 0)
            {
                answer += this[(n/100)%10];
                answer += 7; // length of 'hundred'
            }
            // thousands
            if (n/1000 != 0)
            {
                // length of 'one thousand'
                answer += 11;
            }
            if (n%100 !=0 && n/100 != 0)
            {
                // the 'and' between hundreds and tens and units.
                answer += 3;
            }
                
            return answer;
        }
    }
}