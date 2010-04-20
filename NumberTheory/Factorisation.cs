/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 22:09
 */
using System;

namespace NumberTheory
{
	/// <summary>
	/// Description of Factorisation.
	/// </summary>
	public class Factorisation
	{
		public Factorisation()
		{
		}
		
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
	}
}
