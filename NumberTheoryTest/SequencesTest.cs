/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 23:06
 */

using System;
using NUnit.Framework;
using NumberTheory;

namespace NumberTheoryTest
{
	[TestFixture]
	public class SequencesTest
	{
		[Test]
		public void TestTriangleNumbers()
		{
			int[,] pairs = {{0, 0}, {1, 1}, {2, 3}, {3, 6}, {4, 10},
				{5, 15}, {6, 21}, {7, 28}, {8, 36}, {9, 45}, {10, 55}};
			for (int i = 0; i < pairs.Length/2; i ++)
			{
				Assert.AreEqual(Sequences.TriangleNumber(pairs[i, 0]), pairs[i, 1]);
			}
		}
	}
}
