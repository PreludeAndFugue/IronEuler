/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 23:00
 */
using System;

namespace NumberTheory
{
	/// <summary>
	/// Description of Sequences.
	/// </summary>
	public class Sequences
	{
		public Sequences()
		{
		}
		
		public static int TriangleNumber(int n)
		{
			if (n%2 == 0)
			{
				return (n/2)*(n + 1);
			}
			else
			{
				return ((n + 1)/2)*n;
			}
		}
	}
}
