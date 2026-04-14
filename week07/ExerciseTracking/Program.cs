using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Dec 2025", 30, 3.0));
        activities.Add(new Cycling("18 Jan 2026", 40, 8.9));
        activities.Add(new Swimming("19 Apr 2026", 20, 17));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}