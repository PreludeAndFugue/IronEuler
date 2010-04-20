﻿/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 23:00
 */
using System;using System.Collections.Generic;

namespace NumberTheory
{
	/// <summary>
	/// Description of Sequences.
	/// </summary>
	public class Sequences
	{
		
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
		
		/// <summary>
		/// Generate the hailstone sequence for an integer.
		/// </summary>
		/// <param name="n">The starting integer.</param>
		/// <returns>Array of integers - the Hailstone sequence</returns>
		public static int[] Hailstone(int n)
		{
		    List<int> sequence = new List<int>();
		    sequence.Add(n);
		    while (n != 1)
		    {
		        if (n%2 == 0)
		        {
		            n /= 2;
		        }
		        else
		        {
		            n = 3*n + 1;
		        }
		        sequence.Add(n);
		    }
		    return sequence.ToArray();
		}
	}
}
