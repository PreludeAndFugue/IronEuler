/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 01:08
 */
using System;

namespace NumberTheory
{	
	public class FibonacciGenerator
	{
		private int a = 1;
		private int b = 1;
		
		public int next() 
		{
			int old_b = b;
			b = a + b;
			a = old_b;
			//Console.WriteLine("a = {0}, b = {1}", a, b);
			return a;
		}
	}
	

}