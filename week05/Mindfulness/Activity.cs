using System;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to " + _name);
        Console.WriteLine(_description);
        Console.Write("\nEnter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        Pause(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGood job!");
        Pause(2);
        Console.WriteLine("You completed " + _name + " for " + _duration + " seconds.");
        Pause(2);
    }

    public void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}