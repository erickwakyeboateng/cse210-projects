using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who did you help recently?"
    };

    public ListingActivity()
        : base("Listing Activity",
        "List positive things in your life.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\n" + prompt);
        Console.WriteLine("Start listing items...");
        Pause(2);

        int count = 0;
        int time = 0;

        while (time < _duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
            time += 2; // simple timing estimate
        }

        Console.WriteLine("\nYou listed " + count + " items.");
        EndMessage();
    }
}