/*
Creativity Feature:
This program tracks the total number of activities completed
and displays it when the user exits the program.
*/

using System;

class Program
{
    static void Main()
    {
        

        int choice = 0;
        int totalActivities = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                totalActivities++;
            }
            else if (choice == 2)
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                totalActivities++;
            }
            else if (choice == 3)
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                totalActivities++;
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nYou completed " + totalActivities + " activities today.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}