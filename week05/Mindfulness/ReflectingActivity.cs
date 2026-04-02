using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "How did you feel?",
        "What did you learn?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity",
        "Reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Pause(3);

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            Pause(3);
            time += 3;
        }

        EndMessage();
    }
}