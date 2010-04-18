/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 13:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
//#if TEST

using System;
using NUnit.Framework;
using NumberTheory;

namespace NumberTheoryTest
{
	[TestFixture]
	public class PalindromeTest
	{
		[Test]
		public void TestisPalindrome()
		{
			int[] palindromes = {1, 4, 9, 11, 77, 101, 575, 1331, 9339, 54745,
				91219, 345616543};
			foreach (int p in palindromes)
			{
				Assert.IsTrue(Palindrome.isPalindrome(p), "failure {0}", p);
			}
		}
		
		[Test]
		public void TestNotisPalindrome()
		{
			int[] not_palindromes = {23, 65, 90, 123, 745, 903, 12323, 98379};
			foreach (int p in not_palindromes)
			{
				Assert.IsFalse(Palindrome.isPalindrome(p));
			}
		}
	}
}
//#endif
