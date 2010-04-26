/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 23/04/2010
 * Time: 23:51
 */
using System;
using System.Collections.Generic;
using NumberTypes;

// TODO: euler029 not solved using integers types.

namespace euler029
{
	class Program
	{
	    public static void Main(string[] args)
	    {
	        ListNumber n1 = new ListNumber(1);
	        ListNumber n10 = new ListNumber(10);
	        ListNumber n3 = new ListNumber(3);
	        
	        ListNumber n = n10*n1;
	        Console.WriteLine(n3*n10);
	        
	        int answer = ListNumberCorrect.getAnswer();
	        //int answer = DoubleCheat.getAnswer();
	        
	        Console.WriteLine("Answer: {0}", answer);
	        
	        Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
	    }
	}
	
	class ListNumberCorrect
	{
	    static HashSet<ListNumber> items = new HashSet<ListNumber>();
	    
	    public static int getAnswer()
	    {
	        for (int a = 2; a < 101; a++)
	        {
	            for (int b = 2; b < 101 ; b++)
	            {
	                ListNumber n = new ListNumber(a);
	                items.Add(n.Pow(b));
	            }
	        }
	        return items.Count;
	    }
	}
	
	// using doubles to store the result of exponentiation.
	class DoubleCheat
	{
		static HashSet<double> items = new HashSet<double>();
		
		public static int getAnswer()
		{
			for (int a = 2; a < 101; a++)
			{
				for (int b = 2; b < 101; b++)
				{
					items.Add(Math.Pow(a, b));
				}
			}
			return items.Count;
		}
		
	}
}