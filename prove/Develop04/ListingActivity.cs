using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    
    public ListingActivity(string name, string description, int duration, List<string> prompts) 
    :base (name, description, duration)
    {
        _prompts = prompts;
    }

    public static async Task Run(ListingActivity listing, int duration)
    {
        List<string> responses = [];
        Random random = new Random();
        int randomInt = random.Next(4);
        string picked = listing._prompts[randomInt];
        Activity.Countdown(5, $"{picked} \nYou may begin in... ");
        Console.Clear();
        Console.WriteLine(picked);
        Console.WriteLine("You may begin!");
        int timeLimit = duration - 5;
        var inputTask = Task.Run(() =>
        {
            while (true)
            {
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer))
                {
                    responses.Add(answer);
                }
            }
        });
        await Task.WhenAny(inputTask, Task.Delay(TimeSpan.FromSeconds(timeLimit)));
        Console.WriteLine();
        Console.WriteLine("Times up!");
        Console.WriteLine($"Good job you had {responses.Count} responses");
        Thread.Sleep(5000);
    }
}