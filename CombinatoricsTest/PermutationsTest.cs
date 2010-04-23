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
            List<int> in1 = new List<int>(new int[] {0, 1, 2, 3});
            List<int> out1a = new List<int>(new int[] {1, 3, 0, 2});
            List<int> out1b = Permutations.getPermutation(in1, 11);
            for (int i = 0; i < 4; i++)
            {
            	Assert.AreEqual(out1b[i], out1a[i], "Fail for index {0}", i);
            }
            
            List<int> in2 = new List<int>(new int[] {0, 1, 2, 3});
            List<int> out2 = Permutations.getPermutation(in2, 1);
            for (int i = 0; i < 4; i++)
            {
            	Assert.AreEqual(out2[i], in2[i], "Fail for index {0}", i);
            }
            
            List<int> in3 = new List<int>(new int[] {0, 1, 2, 3});
            List<int> out3a = new List<int>(new int[] {3, 2, 1, 0});
            List<int> out3b = Permutations.getPermutation(in3, 24);
            for (int i = 0; i < 4; i++)
            {
            	Assert.AreEqual(out3b[i], out3a[i], "Fail for index {0}", i);
            }
            
            List<int> in4 = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            List<int> out4a = new List<int>(new int[] {2, 7, 8, 3, 9, 1, 5, 4, 6, 0});
            List<int> out4b = Permutations.getPermutation(in4, 1000000);
            for (int i = 0; i < 4; i++)
            {
            	Assert.AreEqual(out4b[i], out4a[i], "Fail for index {0}", i);
            }
        }
    }
}
