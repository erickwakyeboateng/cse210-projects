using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
        "This helps you relax by breathing slowly.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(3);

            Console.WriteLine("Breathe out...");
            Countdown(3);

            time += 6;
        }

        EndMessage();
    }
}