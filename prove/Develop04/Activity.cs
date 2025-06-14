using System;
using System.Threading.Tasks;

public class Activity
{
    private string _name;

    private string _description;

    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public static void Start(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name} Activity!");
        Console.WriteLine(description);
        Thread.Sleep(5000);
        PauseWithSpinner(10, $"Prepare to begin the {name} Activity... ");
    }

    public static void End(string name, int duration)
    {
        PauseWithSpinner(10, $"You have finished the {name} activity, your activity lasted {duration} seconds... ");
    }

    public static void PauseWithSpinner(int length, string line)
    {
        char[] spinnerChars = { '|', '/', '-', '\\','|', '/', '-', '\\','|', '/', '-', '\\' };
        for (int i = 0; i < length; i++)
        {
            Console.Clear();
            Console.Write(line);
            Console.Write(spinnerChars[i]);
            Thread.Sleep(1000);
        }   
    }

    public static void Countdown(int d, string line)
    {
        Console.Clear();
        Console.WriteLine(line);
        Console.WriteLine(d);
        for (int i = d; i >= 1; i--)
        {
            Console.Clear();
            Console.Write(line);
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    static string GetDuration()
    {
        Console.Write("How long would you like the activity to last (enter multiples of 5 for best results): ");
        return Console.ReadLine();
    }

    public static async Task Run(string name)
    {
        if (name == "B")
        {
            string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            int duration = int.Parse(GetDuration());
            BreathingActivity breathing = new BreathingActivity("Breathing", description, duration);
            Start(breathing._name, breathing._description);
            BreathingActivity.Run(breathing._duration);
            End(breathing._name, breathing._duration);
        }
        if (name == "L")
        {
            string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            int duration = int.Parse(GetDuration());
            List<string> prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
            ListingActivity listing = new ListingActivity("Listing", description, duration, prompts);
            Start(listing._name, listing._description);
            await ListingActivity.Run(listing, listing._duration);
            End(listing._name, listing._duration);
        }
        if (name == "R")
        {
            string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            int duration = int.Parse(GetDuration());
            List<string> prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
            List<string> questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
            ReflectionActivity reflection = new ReflectionActivity("Reflection", description, duration, prompts, questions);
            Start(reflection._name, reflection._description);
            ReflectionActivity.Run(reflection, reflection._duration);
            End(reflection._name, reflection._duration);
        }
    }
}