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
	}
}
