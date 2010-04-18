/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 18/04/2010
 * Time: 22:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace euler006
{
	class euler006
	{
		public static void Main(string[] args)
		{
			int square_sum = 0;
			int sum_square = 0;
			for (int i = 1; i < 101; i++)
			{
				square_sum += i*i;
				sum_square += i;
			}
			sum_square *= sum_square;
			
			int answer = sum_square - square_sum;
			
			Console.Out.WriteLine("Answer: {0}", answer);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}