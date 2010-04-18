/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 00:24
 */
using System;
using NumberTheory;

namespace euler010
{
	class Program
	{
		public static void Main(string[] args)
		{
			long answer = 0;
			PrimesList primes = new PrimesSieve(2000000);
			foreach (int p in primes)
			{
				answer += p;
			}
			Console.Out.WriteLine("Answer: {0}", answer);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}