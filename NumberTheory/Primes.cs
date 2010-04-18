/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 01:43
 */
using System;
using System.Collections.Generic;

namespace NumberTheory
{
	
	/// <summary>
	/// A class for holding some static methods to create lists of primes, etc.
	/// </summary>
	public class Primes
	{
		public static PrimesSieve CreatePrimesFromSieve(int n)
		{
			return new PrimesSieve(n);
		}
		
		public static PrimeFactors GetPrimeFactors(int n, PrimesList primes)
		{
			return new PrimeFactors(n, primes);
		}
	}
	
	/// <summary>
	/// A base class for the different classes the create a list of primes.
	/// </summary>
	public class PrimesList: List<int>
	{
	}
	
	/// <summary>
	/// Generate all primes numbers less than or equal to max using a sieve.
	/// </summary>
	public class PrimesSieve : PrimesList
	{	
		private int[] _primes;
		
		public PrimesSieve(int max)
		{
			fillArray(max);
			generatePrimes(max);
			makeList();
		}
		
		private void fillArray(int max)
		{
			_primes = new int[max + 1];
			for (int i = 0; i <= max; i++) {
				_primes[i] = i;
			}
			_primes[0] = 0;
			_primes[1] = 0;
		}
		
		private void generatePrimes(int max)
		{
			int upper_limit = (int)Math.Sqrt(max) + 1;
			
			// Loop to set all the multiples of 2 to 0.
			for (int i = 4; i <= max; i = i + 2) {
				_primes[i] = 0;
			}
			
			// Only need to check the odd numbers up to the square root of max.
			for (int i = 3; i <= upper_limit; i = i + 2) {
				if (_primes[i] != 0) {
					int index = i*i;
					while (index <= max) {
						_primes[index] = 0;
						// Only need to check the odd multiples, so skip every
						// second multiple.
						index += 2*i;
					}
				}
			}
		}
		
		private void makeList()
		{
			foreach (int i in _primes)
			{
				if (i != 0)
				{
					this.Add(i);
				}
			}
		}
		
		public void printer() {
			foreach (int i in _primes) {
				if (i !=0 ) {
					Console.Out.WriteLine(i);
				}
			}
		}
	}
	
	/// <summary>
	/// The prime factors of an integer n. A list of arrays of integers of length two
	/// where the first integer is the prime factor, and the second prime is the
	/// multiplicity. 
	/// </summary>
	public class PrimeFactors : List<int[]>
	{
		private int number;
		
		public PrimeFactors(int n, PrimesList primes)
		{
			number = n;
			addFactors(primes);
		}
		
		private void addFactors(PrimesList primes)
		{
			foreach (int p in primes)
			{
				addFactor(p);
				if (number == 1)
				{
					break;
				}
			}
		}
		
		private void addFactor(int p)
		{
			int multiplicity = 0;
			while (number%p == 0 && number != 1)
			{
				multiplicity += 1;
				number /= p;
			}
			if (multiplicity > 0)
			{
				int[] new_factor = {p, multiplicity};
				this.Add(new_factor);
			}
		}
	}
}
