/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 12:21
 */

using System;
using NUnit.Framework;
using NumberTheory;

namespace NumberTheoryTest
{
	[TestFixture]
	public class FibonacciGeneratorTest
	{
		[Test]
		public void TestNext()
		{
			int[] small_fib = {1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144};
			FibonacciGenerator fib = new FibonacciGenerator();
			foreach (int i in small_fib)
			{
				Assert.AreEqual(i, fib.next());
			}
		}
	}
}
