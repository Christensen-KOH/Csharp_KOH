using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);

            if (number != 0)
            {
                numbers.Add(number);
            }



        } while (number != 0);

        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int item in numbers)
        {
            if (number > largest)
            {
                largest = item;
            }
        }

        Console.WriteLine($"The largest number is: {largest} ");

        int smallest = numbers[0];
        foreach (int item in numbers)
        {
            if (item < smallest)
            {
                smallest = item;
            }
        }

        Console.WriteLine($"The smallest number is: {smallest}");









    }
}