/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 12:23
 */
//#if TEST

using System;
using NUnit.Framework;
using NumberTheory;

namespace NumberTheoryTest
{
	[TestFixture]
	public class PrimesSieveTest
	{
		int[] small_primes = {2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,
				71,73,79,83,89,97,101,103,107,109,113,127,131,137,139,149,151,157,163,
				167,173,179,181,191,193,197,199,211,223,227,229,233,239,241,251,257,263,
				269,271,277,281,283,293,307,311,313,317,331,337,347,349,353,359,367,373,
				379,383,389,397,401,409,419,421,431,433,439,443,449,457,461,463,467,479,
				487,491,499,503,509,521,523,541};
		
		[Test]
		public void TestFirst100()
		{
			PrimesSieve primes = new PrimesSieve(541);
			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(small_primes[i], primes[i]);
			}
		}
		
		[Test]
		public void TestCreation()
		{
			PrimesSieve primes = Primes.CreatePrimesFromSieve(541);
			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(small_primes[i], primes[i]);
			}
		}
	}
	
	[TestFixture]
	public class PrimeFactorsTest
	{
		
		PrimesList primes;
		
		[SetUp]
		public void Init()
		{
			primes = new PrimesSieve(10000);
		}
		
		[Test]
		public void Test4()
		{
			PrimeFactors pf = new PrimeFactors(4, primes);
			int prime = pf[0][0];
			int multiplicity = pf[0][1];
			Assert.AreEqual(prime, 2);
			Assert.AreEqual(multiplicity, 2);
		}
		
		[Test]
		public void Test2()
		{
			PrimeFactors pf = new PrimeFactors(2, primes);
			int prime = pf[0][0];
			int multiplicity = pf[0][1];
			Assert.AreEqual(prime, 2);
			Assert.AreEqual(multiplicity, 1);
		}
		
		[Test]
		public void Test6()
		{
			PrimeFactors pf = new PrimeFactors(6, primes);
			int prime = pf[0][0];
			int multiplicity = pf[0][1];
			Assert.AreEqual(prime, 2);
			Assert.AreEqual(multiplicity, 1);
			prime = pf[1][0];
			multiplicity = pf[1][1];
			Assert.AreEqual(prime, 3);
			Assert.AreEqual(multiplicity, 1);
		}
		
		[Test]
		public void Test23()
		{
			PrimeFactors pf = new PrimeFactors(23, primes);
			int prime = pf[0][0];
			int multiplicity = pf[0][1];
			Assert.AreEqual(prime, 23);
			Assert.AreEqual(multiplicity, 1);
		}
	}
}
//#endif
