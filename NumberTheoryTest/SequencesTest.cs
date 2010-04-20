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
		
		[Test]
		public void TestHailstone()
		{
		    int[] hail10 = {10, 5, 16, 8, 4, 2, 1};
		    int[] hail2 = {2, 1};
		    int[] hail21 = {21, 64, 32, 16, 8, 4, 2, 1};
		    int[] hail7 = {7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1};
		    int[][] tests = {hail10, hail2, hail21, hail7};
		    foreach (int[] test in tests)
		    {
		        int[] hail = Sequences.Hailstone(test[0]);
		        Assert.AreEqual(hail.Length, test.Length);
		        for (int i = 0; i < hail.Length; i++)
		        {
		            Assert.AreEqual(hail[i], test[i]);
		        }
		    }
		}
	}
}
