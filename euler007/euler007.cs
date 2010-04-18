/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NumberTheory;

namespace euler007
{
	class euler007
	{
		public static void Main(string[] args)
		{
			PrimesList primes = new PrimesSieve(110000);
			
			// The 10001st prime is at index 10000 in the list.
			Console.Out.WriteLine("10001st prime: {0}", primes[10000]);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}