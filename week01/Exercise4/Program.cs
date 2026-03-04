using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int convertedUserInput = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            convertedUserInput = int.Parse(userInput);

            if (convertedUserInput != 0)
            {
                numbers.Add(convertedUserInput);
            }

        } while (convertedUserInput != 0);
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        double average = (double)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
            
    } 
        
    
}