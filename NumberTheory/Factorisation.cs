/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 22:09
 */
using System;
using System.Collections.Generic;

namespace NumberTheory
{
	/// <summary>
	/// Description of Factorisation.
	/// </summary>
	public class Factorisation
	{
		
		public static int gcd(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a%b;
				a = temp;
			}
			return a;
		}
		
		public static int lcm(int a, int b)
		{
			return (a/gcd(a, b))*b;
		}
		
		/// <summary>
		/// Calculate the positive divisors of a positive integer n.
		/// </summary>
		/// <param name="n">Positive integer</param>
		/// <returns>Ordered array of integer divisors of n.</returns>
		public static int[] divisors(int n)
		{
		    int[] proper_divisors = ProperDivisors(n);
		    List<int> _result = new List<int>(proper_divisors);
		    _result.Add(n);
		    //_result.Sort();
		    return _result.ToArray();
		}
		
		public static int[] ProperDivisors(int n)
		{
		    List<int> _result = new List<int>();
		    _result.Add(1);
			
			int upper_limit = (int)Math.Sqrt(n);
			
			/* Simple algorithm which loops through all integers less than the square root of n
			 * checking if it is a divisor. */
			for (int i = 2; i < upper_limit; i++)
			{
				if (n%i == 0)
				{
					_result.Add(i);
					_result.Add(n/i);
				}
			}
			
			if (n%upper_limit == 0 && upper_limit > 1)
			{
				_result.Add(upper_limit);
				int other_divisor = n/upper_limit;
				if (other_divisor != upper_limit)
				{
					_result.Add(other_divisor);
				}
			}
			
			_result.Sort();
			
			int[] result = _result.ToArray();
			return result;
		}
		
		public static bool isPerfectNumber(int n)
		{
		    int[] proper_divisors = ProperDivisors(n);
		    int sum_pd = 0;
		    foreach (int i in proper_divisors)
		    {
		        sum_pd += i;
		    }
		    return n == sum_pd;
		}
		
		public static bool isAbundantNumber(int n)
		{
		    int[] proper_divisors = ProperDivisors(n);
		    int sum_pd = 0;
		    foreach (int i in proper_divisors)
		    {
		        sum_pd += i;
		    }
		    return n < sum_pd;
		}
	}
}
