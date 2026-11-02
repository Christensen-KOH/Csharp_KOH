using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations, you PASS !!!");
        }

        else
        {
            Console.WriteLine("Sorry but you did NOT pass. Better luck next time");
        }
    }
}