using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine($"\nYou have {score} points.\n");
            DisplayPlayerStatus(score);
            string userChoice = Menu();

            switch (userChoice.ToUpper())
            {
                case "C":
                    CreateNewGoal(goals);
                    break;
                case "D":
                    ListGoals(goals);
                    break;
                case "S":
                    SaveGoals(goals, score);
                    break;
                case "L":
                    score = LoadGoals(goals);
                    break;
                case "R":
                    score += RecordEvent(goals);
                    break;
                case "Q":
                    Console.WriteLine("Ending Program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static string Menu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("[C]reate New Goal");
        Console.WriteLine("[D]isplay Goals");
        Console.WriteLine("[S]ave Goals");
        Console.WriteLine("[L]oad Goals");
        Console.WriteLine("[R]ecord Event");
        Console.WriteLine("[Q]uit");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("[S]imple Goal");
        Console.WriteLine("[E]ternal Goal");
        Console.WriteLine("[C]hecklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "S":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "E":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "C":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    static int RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            if (!goals[i].IsComplete())
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
            }
        }
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            int pointsEarned = goals[choice].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            return pointsEarned;
        }

        Console.WriteLine("Invalid goal selection.");
        return 0;
    }

    static void SaveGoals(List<Goal> goals, int score)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.ToFileFormat());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static int LoadGoals(List<Goal> goals)
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() + ".txt";
        goals.Clear();
        int score = 0;

        try
        {
            string[] lines = File.ReadAllLines(filename);
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                Goal goal = null;
                if (type == "SimpleGoal")
                {
                    goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3]))
                    {
                        goal.RecordEvent();
                    }
                }
                else if (type == "EternalGoal")
                {
                    goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                }
                else if (type == "ChecklistGoal")
                {
                    goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                    int currentAmount = int.Parse(data[5]);
                    for (int j = 0; j < currentAmount; j++)
                    {
                        ((ChecklistGoal)goal).SetCurrentAmount(currentAmount);
                    }
                }

                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading goals: {e.Message}");
        }

        return score;
    }

    static void DisplayPlayerStatus(int score)
    {
        Console.WriteLine($"\nYou have {score} points.");
        int level = (score / 50) + 1;
        Console.WriteLine($"Your current level is: {level}\n");
    }
}

