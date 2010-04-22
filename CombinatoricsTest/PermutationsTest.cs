/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 22/04/2010
 * Time: 14:41
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;
using Combinatorics;

namespace CombinatoricsTest
{
    [TestFixture]
    public class PermutationsTest
    {
        [Test]
        public void getPermutationIntTest()
        {
            List<int> in1 = new List<int>(new int[] {0, 1, 2});
            List<int> out1a = new List<int>(new int[] {2, 0, 1});
            List<int> out1b = Permutations.getPermutation(in1, 5);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(out1a[i], out1b[i], "Fail for index {0}", i);
            }
        }
    }
}
