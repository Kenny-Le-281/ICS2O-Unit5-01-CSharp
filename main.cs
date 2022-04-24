// Created by: Kenny Le
// Created on: Apr 2022
//
// This program guesses the correct number

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program guesses the correct number
        int guess;
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 6);
      
        // input 
        Console.WriteLine("This program guesses a number between 1-6");

        Console.WriteLine("");
        Console.Write("Input a number between 1-6: ");
        guess = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (guess == number)
        {
            Console.WriteLine("You are correct!");
        }

        if (guess != number)
        {
            Console.WriteLine("You are incorrect!");
        }

        Console.WriteLine("\nDone.");
    }
}