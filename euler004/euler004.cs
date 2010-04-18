/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 17:51
 */
using System;
using NumberTheory;

namespace euler004
{
	class Program
	{
		public static void Main(string[] args)
		{
			int largest_palindrome = 0;
			for (int i = 800; i < 1000; i++)
			{
				for (int j = 800; j < 1000; j++)
				{
					int p = i*j;
					if (Palindrome.isPalindrome(p) && p > largest_palindrome)
					{
						largest_palindrome = p;
					}
				}
			}
			
			Console.Out.WriteLine("Largest palindrome: {0}", largest_palindrome);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}