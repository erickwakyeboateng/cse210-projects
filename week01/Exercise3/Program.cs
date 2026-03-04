using System;

class Program
{
    static void Main(string[] args)
    {
        int number, guess, numberOfGuess;
        numberOfGuess = 0;

        Random randomGenerator = new Random();
        number = randomGenerator.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            numberOfGuess++;

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
                Console.WriteLine($"You guessed {numberOfGuess} times");
            }

        } while (number != guess);  
    }
}