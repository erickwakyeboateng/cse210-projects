using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput);
        string letter;

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B"; ;
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (userGrade >= 70)
        {
            Console.WriteLine($"Congratulations!!!! You scored {userGrade}, You passed the Course.");
        }

        else
        {
            Console.WriteLine($"Sorry! You scored {userGrade}, You failed the Course.");
        }

        
    }
}