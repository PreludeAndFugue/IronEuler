/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 23/04/2010
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using NumberTheory;

namespace euleur026
{
	class Program
	{
		public static void Main(string[] args)
		{
			int max_order = 0;
			int answer = 0;
			
			for (int i = 2; i < 1000; i++)
			{
				int current_order = Factorisation.order(10, i);
				if (current_order > max_order)
				{
					max_order = current_order;
					answer = i;
				}
				
			}
			
			Console.WriteLine("{0}: order: {1}", answer, max_order);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}