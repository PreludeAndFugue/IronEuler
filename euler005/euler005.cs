/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 22:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NumberTheory;

namespace euler005
{
	class Program
	{
		public static void Main(string[] args)
		{
			int answer = 1;
			for (int i = 2; i < 21; i++)
			{
				answer = Factorisation.lcm(answer, i);
			}
			Console.Out.WriteLine("lcm: {0}", answer);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}