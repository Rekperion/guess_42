/*
*   Simple number guessing game.
*   The correct answer is 42.
*   All answers that aren't 42 should return incorrect.
*/

using System;

public class guess42
{
    public static void Main(string[] args)
    {
        bool guessing = true;
        // loop while guessing
        Console.WriteLine("Guess the number from 1-100!");
        while (guessing)
        {
            // ask the question
            Console.Write("Guess the answer: ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 42)
                {
                    // correct response
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    // incorrect response
                    Console.WriteLine("Incorrect!");
                }
                }
            catch
            {
                Console.WriteLine("Guess must be a number.");
                continue;
            }
        }
        // close program
        Console.WriteLine("Hit any key to close program...");
        Console.ReadKey();
    }
}