using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project. In this program, we are going to test some random things");
        Console.WriteLine("Hi man");


        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();

        Console.WriteLine("How old are you?: ");
        int age = Console.ReadLine();

        Console.WriteLine("What is your favorite color");
        string color = Console.ReadLine();

        if (age < 50)
        {
            Console.WriteLine("You are young");
        }

        if (age > 50)
        {
            Console.WriteLine("You are old");
        }

        Console.WriteLine($"Welcome {name}. You are {age} and your favorite color is {color}");
    }
}