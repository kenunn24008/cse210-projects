using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;

    private static Random rng = new Random();

    public ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
    : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public static void Run(ReflectionActivity reflection, int duration)
    {
        ShuffleList(reflection._questions);
        int amountQuestions = (duration - 5) / 5;
        Random random = new Random();
        int randomInt = random.Next(3);
        string picked = reflection._prompts[randomInt];
        Activity.PauseWithSpinner(5, $"{picked}... ");
        Console.Clear();
        Console.WriteLine(picked);
        for (int i = 1; i <= amountQuestions; i++)
        {
            randomInt = random.Next(7);
            string question = reflection._questions[randomInt];
            Activity.PauseWithSpinner(5, $"{picked}\n\n{question}... ");
        }
    }

    private static void ShuffleList<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}