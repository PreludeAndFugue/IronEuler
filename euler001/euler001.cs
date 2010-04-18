/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 17/04/2010
 * Time: 23:46
 * 
 */
using System;

namespace euler001
{
	class Program
	{
		public static void Main(string[] args)
		{
			int total = 0;
			for (int i=0; i < 1000; i++) {
				if (i%3 == 0 || i%5 == 0) {
					total += i;
				}
			}
			Console.WriteLine("answer: {0}", total);
			Console.ReadLine();
		}
	}
}