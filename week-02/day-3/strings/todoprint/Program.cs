﻿using System;

namespace todoprint
{
    class Program
    {
        static void Main(string[] args)
        {
			string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            todoText = todoText.Insert(todoText.Length, " - Download games \n     - Diablo");

			Console.WriteLine(todoText);
        }
    }
}
