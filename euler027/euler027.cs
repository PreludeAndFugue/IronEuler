/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 23/04/2010
 * Time: 22:56
 */
using System;
using NumberTheory;

namespace euler027
{
	class Program
	{
		static PrimesList b_vals = new PrimesSieve(1000);
		static int a_answer, b_answer, p_count;
		
		public static void Main(string[] args)
		{
			p_count = 0;
			for (int a = -999; a < 1000; a++)
			{
				foreach (int b in b_vals)
				{
					int p = countPrimes(a, b);
					if (p > p_count)
					{
						p_count = p;
						a_answer = a;
						b_answer = b;
					}
				}
			}
			
			Console.WriteLine("a: {0}, b: {1}, a*b: {2}, p: {3}",
			                  a_answer, b_answer, a_answer*b_answer, p_count);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int countPrimes(int a, int b)
		{
			int count = 0;
			for (int n = 0; ; n++)
			{
				if (!isPrime(n*(n + a) + b))
					break;
				count++;
			}
			
			return count;
		}
		
		public static bool isPrime(int n)
		{
			if (n <= 1)
				return false;
			for (int i = 2; i*i < n; i++)
			{
				if (n%i == 0)
					return false;
			}
			return true;
		}
	}
}