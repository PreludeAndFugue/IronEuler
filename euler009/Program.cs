/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 00:05
 * 
 * Need to find integer b = 1000(500 - a)/(1000 - a), where 1 < a < 500.
 * 
 */
using System;
using NumberTheory;

namespace euler009
{
	class Program
	{
		public static void Main(string[] args)
		{
			int answer = 1;
			for (int a = 1; a < 500; a++)
			{
				if (isIntegerB(a))
				{
					int b = getB(a);
					int c = 1000 - a - b;
					if (a*b*c > answer && a*a + b*b == c*c) 
					{
						answer = a*b*c;
						//Console.Out.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);
					}
				}
			}
			
			Console.Out.WriteLine("Answer: {0}", answer);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		private static bool isIntegerB(int a)
		{
			int num = 1000*(500 - a);
			int den = 1000 - a;
			return Factorisation.gcd(num, den) > 1;
		}
		
		private static int getB(int a)
		{
			return (1000*(500 - a))/(1000 - a);
		}
	}
}