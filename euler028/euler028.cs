/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 23/04/2010
 * Time: 23:43
 */
using System;

namespace euler028
{
	class Program
	{
		public static void Main(string[] args)
		{
			// formula for each square: 4n*n - 6n + 6 where n = 3, 5, 7, ..., 1001
			int sum = 1;
			for (int n = 3; n <= 1001; n += 2)
			{
				sum += 4*n*n - 6*n + 6;
			}
			
			Console.WriteLine("Answer: {0}", sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}