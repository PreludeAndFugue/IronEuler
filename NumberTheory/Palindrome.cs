/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 13:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumberTheory
{
	/// <summary>
	/// A class for dealing with palindromic number tests.
	/// </summary>
	public class Palindrome
	{
		public static bool isPalindrome(int p)
		{
			char[] new_p = p.ToString().ToCharArray();
			int half_len = new_p.Length/2;
			for (int i = 0; i <= half_len; i++)
			{
				if (new_p[i] != new_p[new_p.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
