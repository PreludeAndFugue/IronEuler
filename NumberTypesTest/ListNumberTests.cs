/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 23/04/2010
 * Time: 11:47
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;
using NumberTypes;

namespace NumberTypesTest
{
    [TestFixture]
    public class ListNumberTests
    {
        ListNumber n1, n2, n3, n4, n8, n10, n13, n21, n25a, n25b, n25c, n30, n50, n100, n88;
        
        [SetUp]
        public void Init()
        {
            n1 = new ListNumber(1);
            n2 = new ListNumber(2);
            n3 = new ListNumber(3);
            n4 = new ListNumber(4);
            n8 = new ListNumber(8);
            n10 = new ListNumber(10);
            n13 = new ListNumber(13);
            n21 = new ListNumber(21);
            n25a = new ListNumber(25);
            n25b = new ListNumber(25);
            List<int> n25c_list = new List<int>(new int[] {2, 5});
            n25c = new ListNumber(n25c_list);
            n30 = new ListNumber(30);
            n50 = new ListNumber(50);
            n88 = new ListNumber(88);
            n100 = new ListNumber(100);
        }
        
        [Test]
        public void TestEquality()
        {
            Assert.IsTrue(n25a == n25b);
            Assert.IsTrue(n25a == n25c);
        }
        
        [Test]
        public void TestInequality()
        {
            Assert.IsTrue(n25a != n100);
            Assert.IsFalse(n25a != n25b);
        }
        
        [Test]
        public void TestGreaterThan()
        {
            Assert.IsTrue(n88 > n25a);
            Assert.IsTrue(n100 > n88);
            Assert.IsFalse(n25b > n100);
        }
        
        [Test]
        public void TestLessThan()
        {
            Assert.IsTrue(n25b < n88);
            Assert.IsTrue(n25c < n100);
            Assert.IsFalse(n100 < n88);
        }
        
        [Test]
        public void TestGreaterThanEqualTo()
        {
            Assert.IsTrue(n25a >= n25b);
            Assert.IsTrue(n88 >= n25a);
            Assert.IsTrue(n100 >= n88);
            Assert.IsFalse(n25b >= n100);
        }
        
        [Test]
        public void TestLessThanEqualTo()
        {
            Assert.IsTrue(n25b <= n25a);
            Assert.IsTrue(n25b <= n88);
            Assert.IsTrue(n25c <= n100);
            Assert.IsFalse(n100 <= n88);
        }
        
        [Test]
        public void TestAddition()
        {
            Assert.AreEqual(n1 + n1, n2);
            Assert.AreEqual(n1 + n2, n3);
            Assert.AreEqual(n8 + n13, n21);
            Assert.AreEqual(n25a + n25b, n50);
        }
        
        [Test]
        public void TestMultiplicationInt()
        {
            Assert.AreEqual(n25a*2, n50);
            Assert.AreEqual(n25b*4, n100);
            Assert.AreEqual(n10*10, n100);
            Assert.AreEqual(10*n10, n100);
        }
        
        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual(n10*n10, n100);
            Assert.AreEqual(n10*n3, n30);
            Assert.AreEqual(n25b*n4, n100);
            Assert.AreEqual(n4*n25b, n100);
        }
        
        [Test]
        public void TestPow()
        {
            Assert.AreEqual(n10.Pow(2), n100);
            Assert.AreEqual(n2.Pow(3), n8);
            Assert.AreEqual(n25a.Pow(1), n25a);
            Assert.AreEqual(n3.Pow(0), n1);
        }
    }
}
