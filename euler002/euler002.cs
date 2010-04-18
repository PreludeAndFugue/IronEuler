/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 17/04/2010
 * Time: 23:56
 * 
 */
using System;
using NumberTheory;

namespace euler002
{
	class euler002
	{
		public static void Main(string[] args)
		{
			FibonacciGenerator fib = new FibonacciGenerator();
			int total = 0;
			
			for (int i = fib.next(); i < 4000000; i = fib.next()) {
				if (i%2 == 0) {
					total += i;
				}
			}
			Console.Out.WriteLine("answer: {0}", total);
			Console.In.ReadLine();
		}
	}
}