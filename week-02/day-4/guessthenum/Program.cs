﻿using System;

namespace guessthenum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stored number is lower
            // You found the number: 8
            Random randy = new Random();
            int randyInt = randy.Next(1,100);
            int numGuessed;

            do
            {
				Console.WriteLine("Guess the number!");
				numGuessed = int.Parse(Console.ReadLine());

                if (numGuessed>randyInt)
                {
                    Console.WriteLine("The stored number is lower");
                }

                else if (numGuessed < randyInt)
				{
					Console.WriteLine("The stored number is higher");
				}
            } 
            while (randyInt != numGuessed);


            Console.WriteLine("You found the number");
			
             



            Console.ReadLine();
        }
    }
}
