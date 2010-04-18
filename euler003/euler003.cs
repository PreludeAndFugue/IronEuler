/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 01:26
 */
using System;
using System.Collections.Generic;
using NumberTheory;

namespace euler003
{
	class euler003
	{
		public static void Main(string[] args)
		{
			// The first 10,000 primes
			Primes primes = new Primes(104729);
			
			List<int> primeFactors = new List<int>();
			
			List<int>.Enumerator p = primes.GetEnumerator();
			long n = 600851475143;
			while (n != 1) {
				p.MoveNext();
				while (n%p.Current == 0 && n != 1)
				{
					primeFactors.Add(p.Current);
					n /= p.Current;
				}
			}
			
			Console.Out.WriteLine("Answer: {0}", primeFactors[primeFactors.Count - 1]);
			
			Console.Out.WriteLine("Press any key to continue . . . ");
			Console.In.ReadLine();
		}

	}
}