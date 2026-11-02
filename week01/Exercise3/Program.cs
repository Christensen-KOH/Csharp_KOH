using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        Random numberGenerator = new Random();
        int magicNumber = numberGenerator.Next(1, 101);

        int guess;

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        while (guess != magicNumber);

        Console.WriteLine("You guessed it !!!");

       


    }
}