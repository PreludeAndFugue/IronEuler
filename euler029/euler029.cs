/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 23/04/2010
 * Time: 23:51
 */
using System;
using System.Collections.Generic;

namespace euler029
{
	class Program
	{
		public static void Main(string[] args)
		{
			int answer = DoubleCheat.getAnswer();
			
			Console.WriteLine("Answer: {0}", answer);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
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