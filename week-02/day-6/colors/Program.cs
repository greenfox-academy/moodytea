﻿using System;

namespace colors
{
    class Program
    {
        static void Print2DArray(string[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.WriteLine("Element({0},{1})={" , "}", i, j, arr[i, j]);
				}
			}
		}

        static void Main(string[] args)
        {
			// - Create a two dimensional array
			//   which can contain the different shades of specified colors
			// - In `colors[0]` store the shades of green:
			//   `"lime", "forest green", "olive", "pale green", "spring green"`
			// - In `colors[1]` store the shades of red:
			//   `"orange red", "red", "tomato"`
			// - In `colors[2]` store the shades of pink:
			//   `"orchid", "violet", "pink", "hot pink"`

            string [][] colors = new string[3][];
            colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[] { "orange red", "red", "tomato" };
            colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };

            Print2DArray(colors);
			Console.ReadLine();
        }
    }
}
