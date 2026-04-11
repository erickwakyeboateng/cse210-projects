using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("=================================");
        Console.WriteLine("       Eternal Quest Program");
        Console.WriteLine("=================================");
        Console.WriteLine($"Current Score: {_score}");
        DisplayLevel();

        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Create a New Goal");
        Console.WriteLine("2. View Goals");
        Console.WriteLine("3. Record Progress");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Exit");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();

        Console.Clear();

        if (choice == "1") CreateGoal();
        else if (choice == "2") ListGoals();
        else if (choice == "3") RecordEvent();
        else if (choice == "4") SaveGoals();
        else if (choice == "5") LoadGoals();
        else if (choice == "6") break;
        else Console.WriteLine("Invalid choice. Please try again.");

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}

    private void DisplayLevel()
    {
        int level = _score / 1000;
        Console.WriteLine($"Level: {level}");
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal (one-time completion)");
        Console.WriteLine("2. Eternal Goal (repeatable)");
        Console.WriteLine("3. Checklist Goal (multiple completions required)");

        Console.Write("\nEnter your choice: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saving goals...");
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    bool.Parse(data[3])
                ));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2])
                ));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[5]),
                    int.Parse(data[4])
                ));
            }
        }

        Console.WriteLine("Loading goals...");
        Console.WriteLine("Goals loaded successfully.");;
    }
}