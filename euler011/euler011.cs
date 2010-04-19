/*
 * Created by SharpDevelop.
 * User: gdk
 * Date: 19/04/2010
 * Time: 22:09
 */
using System;
using System.IO;

namespace euler011
{
	class Program
	{
		public static void Main(string[] args)
		{			
			string file_location = @"C:\Documents and Settings\gdk\My Documents\computing\C#\Euler\euler011\euler011.txt";
			StreamReader data = new StreamReader(file_location);
			
			int[,] grid = createGrid(data);
			
			int max_sum = 1;
			max_sum = searchRight(grid, max_sum);
			max_sum = searchDown(grid, max_sum);
			max_sum = searchDiagRight(grid, max_sum);
			max_sum = searchDiagLeft(grid, max_sum);
			
			Console.Out.WriteLine("Answer: {0}", max_sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		private static int[,] createGrid(StreamReader data)
		{
			int [,] grid = new int[20, 20];
			int row_counter = 0;
			string row;
			while ((row = data.ReadLine()) != null)
			{
				string[] items = row.Split(' ');
				for (int i = 0; i < 20; i++)
				{
					grid[row_counter, i] = int.Parse(items[i]);
				}
				row_counter++;
			}
			return grid;
		}
		
		private static int searchRight(int[,] grid, int max_sum)
		{
			for (int i = 0; i < 20; i++)
			{
				for (int j = 0; j < 17; j++)
				{
					int prod = 1;
					for (int k = 0; k < 4; k++)
					{
						prod *= grid[i, j + k];
					}
					max_sum = max_sum > prod ? max_sum: prod;
				}
			}
			return max_sum;
		}
		
		private static int searchDown(int[,] grid, int max_sum)
		{
			for (int i = 0; i < 17; i++)
			{
				for (int j = 0; j < 20; j++)
				{
					int prod = 1;
					for (int k = 0; k < 4; k++)
					{
						prod *= grid[i + k, j];
					}
					max_sum = max_sum > prod ? max_sum: prod;
				}
			}
			return max_sum;
		}
		
		private static int searchDiagRight(int[,] grid, int max_sum)
		{
			for (int i = 0; i < 17; i++)
			{
				for (int j = 0; j < 17; j++)
				{
					int prod = 1;
					for (int k = 0; k < 4; k++)
					{
						prod *= grid[i + k, j + k];
					}
					max_sum = max_sum > prod ? max_sum: prod;
				}
			}
			return max_sum;
		}
		
		private static int searchDiagLeft(int[,] grid, int max_sum)
		{
			for (int i = 0; i < 17; i++)
			{
				for (int j = 3; j < 20; j++)
				{
					int prod = 1;
					for (int k = 0; k < 4; k++)
					{
						prod *= grid[i + k, j - k];
					}
					max_sum = max_sum > prod ? max_sum: prod;
				}
			}
			return max_sum;
		}
	}
}