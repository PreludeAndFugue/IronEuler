/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 28/04/2010
 * Time: 22:46
 */

using System;
using NUnit.Framework;

using NumberTypes;

namespace NumberTypesTest
{
	[TestFixture]
	public class FractionTests
	{
		Fraction f0, f0a, f0b;
		Fraction f1_2, f1_3, f2_4, f1_4;
		Fraction f2_1, f3_1, f10_5;
		Fraction f_1_2a, f_1_2b;
		
		[SetUp]
		public void Init()
		{
			f0 = new Fraction(0, 1);
			f0a = new Fraction(0, 4);
			f0b = new Fraction(0, -123);
			
			f1_2 = new Fraction(1, 2);
			f1_3 = new Fraction(1, 3);
			f2_4 = new Fraction(2, 4);
			f1_4 = new Fraction(1, 4);
			
			f2_1 = new Fraction(2, 1);
			f3_1 = new Fraction(3, 1);
			f10_5 = new Fraction(10, 5);
			
			f_1_2a = new Fraction(-1, 2);
			f_1_2b = new Fraction(1, -2);
		}
		
		[Test]
		public void TestCreation()
		{
			Assert.AreEqual(f1_2, f2_4);
			Assert.AreEqual(f2_1, f10_5);
			Assert.AreEqual(f_1_2a, f_1_2b);
			Assert.Throws<ArgumentException>(CreateZeroDenominator);
		}
		
		void CreateZeroDenominator()
		{
			Fraction f0 = new Fraction(43, 0);
		}
		
		[Test]
		public void TestNumeratorDenominator()
		{
			Assert.AreEqual(f1_2.num, 1);
			Assert.AreEqual(f1_2.den, 2);
			Assert.AreEqual(f_1_2a.num, -1);
			Assert.AreEqual(f_1_2a.den, 2);
			Assert.AreEqual(f_1_2b.num, -1);
			Assert.AreEqual(f_1_2b.den, 2);
			Assert.AreEqual(f2_4.num, 1);
			Assert.AreEqual(f2_4.den, 2);
			Assert.AreEqual(f10_5.num, 2);
			Assert.AreEqual(f10_5.den, 1);
		}
		
		[Test]
		public void TestZero()
		{
			Assert.AreEqual(f0, f0a);
			Assert.AreEqual(f0, f0b);
			Assert.AreEqual(f0a, f0b);
			Assert.AreEqual(f0.num, 0);
			Assert.AreEqual(f0a.num, 0);
			Assert.AreEqual(f0b.num, 0);
			Assert.AreEqual(f0.den, 1);
			Assert.AreEqual(f0a.den, 1);
			Assert.AreEqual(f0b.den, 1);
		}
		
		[Test]
		public void TestGreaterThan()
		{
			Assert.IsTrue(f1_2 > f1_3);
			Assert.IsTrue(f2_1 > f1_3);
			Assert.IsTrue(f2_1 > f1_2);
			Assert.IsTrue(f1_4 > f_1_2a);
			Assert.IsTrue(f1_3 > f_1_2a);
		}
		
		[Test]
		public void TestLessThan()
		{
			
		}
		
		[Test]
		public void TestGreaterThanOrEqual()
		{
			
		}
		
		[Test]
		public void TestLessThanOrEqual()
		{
			
		}
		
		[Test]
		public void TestEqual()
		{
			
		}
		
		[Test]
		public void TestNotEqual()
		{
			Assert.IsTrue(f1_2 != f1_3);
			Assert.IsTrue(f2_1 != f1_3);
			Assert.IsTrue(f2_1 != f1_2);
			Assert.IsTrue(f1_4 != f_1_2a);
			Assert.IsTrue(f1_3 != f_1_2a);
		}
		
		[Test]
		public void TestAddition()
		{
			
		}
		
		[Test]
		public void TestSubtraction()
		{
			
		}
		
		[Test]
		public void TestMultiplication()
		{
			
		}
		
		[Test]
		public void TestDivision()
		{
			
		}
	}
}
