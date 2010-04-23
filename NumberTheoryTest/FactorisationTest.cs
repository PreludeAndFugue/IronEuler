/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 22:13
 */

using System;
using NUnit.Framework;
using NumberTheory;

namespace NumberTheoryTest
{
	[TestFixture]
	public class FactorisationTest
	{
		[Test]
		public void gcdTest()
		{
			Assert.AreEqual(Factorisation.gcd(5, 10), 5);
			Assert.AreEqual(Factorisation.gcd(10, 5), 5);
			Assert.AreEqual(Factorisation.gcd(1071, 462), 21);
			Assert.AreEqual(Factorisation.gcd(5, 7), 1);
			Assert.AreEqual(Factorisation.gcd(252, 105), 21);
		}
		
		[Test]
		public void lcmTest()
		{
			Assert.AreEqual(Factorisation.lcm(21, 6), 42);
			Assert.AreEqual(Factorisation.lcm(6, 21), 42);
			Assert.AreEqual(Factorisation.lcm(4, 6), 12);
			Assert.AreEqual(Factorisation.lcm(48, 180), 720);
			Assert.AreEqual(Factorisation.lcm(5, 7), 35);
		}
		
		[Test]
		public void divisorsTest()
		{
			int[] div_test_10 = {1, 2, 5, 10};
			int[] div_test_23 = {1, 23};
			int[] div_test_2 = {1, 2};
			int[] div_test_24 = {1, 2, 3, 4, 6, 8, 12, 24};
			int[][] tests = {div_test_10, div_test_23, div_test_2, div_test_24};
			foreach (int[] test in tests)
			{
				int n = test[test.Length - 1];
				int[] divs = Factorisation.divisors(n);
				Assert.AreEqual(test.Length, divs.Length, "Test for {0} ->", n);
				for (int i = 0; i < divs.Length; i++)
				{
					Assert.AreEqual(divs[i], test[i]);
				}
			}
		}
		
		[Test]
		public void powmodTest()
		{
		    Assert.AreEqual(Factorisation.powmod(5, 100, 17), 13);
		}
		
		[Test]
		public void orderTest()
		{
		    Assert.AreEqual(Factorisation.order(4, 7), 3);
		}
		
		[Test]
		public void ProperDivisorsTest()
		{
		    int[] test_nums = {10, 23, 2, 24, 4};
			int[] div_test_10 = {1, 2, 5};
			int[] div_test_23 = {1};
			int[] div_test_2 = {1};
			int[] div_test_24 = {1, 2, 3, 4, 6, 8, 12};
			int[] div_test_4 = {1, 2};
			int[][] tests = {div_test_10, div_test_23, div_test_2, div_test_24, div_test_4};
			for (int i = 0; i < 4; i++)
			{
			    int n = test_nums[i];
			    int[] test_divs = tests[i];
				int[] divs = Factorisation.ProperDivisors(n);
				Assert.AreEqual(test_divs.Length, divs.Length, "Test length for {0} -> ", n);
				for (int j = 0; j < divs.Length; j++)
				{
					Assert.AreEqual(divs[j], test_divs[j], "Test contents for {0} -> ", n);
				}
			}
		}
		
		[Test]
		public void PerfectNumberTest()
		{
		    int[] p_nums = {6, 28, 496, 8128};
		    foreach (int i in p_nums)
		    {
		        Assert.IsTrue(Factorisation.isPerfectNumber(i));
		    }
		    
		    int[] not_p_nums = {7, 27, 1023, 2568};
		    foreach (int i in not_p_nums)
		    {
		        Assert.IsFalse(Factorisation.isPerfectNumber(i));
		    }
		}
		
		[Test]
		public void AbundantNumberTest()
		{
		    int[] a_nums = {12, 18, 40, 42, 102};
		    foreach (int i in a_nums)
		    {
		        Assert.IsTrue(Factorisation.isAbundantNumber(i));
		    }
		    
		    int[] not_a_nums = {13, 14, 101, 82};
		    foreach (int i in not_a_nums)
		    {
		        Assert.IsFalse(Factorisation.isAbundantNumber(i));
		    }
		}
	}
}
