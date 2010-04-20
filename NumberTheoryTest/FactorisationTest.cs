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
	}
}
