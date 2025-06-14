using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        int i = 1;
        int amountR = 0;
        int amountB = 0;
        int amountL = 0;
        List<string> activities = [];
        while (i == 1)
        {
            string userChoice = Menu();
            activities.Add(userChoice);
            await Activity.Run(userChoice);
            if (userChoice == "Q")
            {
                for (int a = 0; a < activities.Count; a++)
                {
                    if (activities[a] == "B")
                    {
                        amountB++;
                    }
                    if (activities[a] == "R")
                    {
                        amountR++;
                    }
                    if (activities[a] == "L")
                    {
                        amountL++;
                    }
                }
                Console.WriteLine($"Congrats! You completed the Breathing activity {amountB} times!");
                Console.WriteLine($"Congrats! You completed the Reflection activity {amountR} times!");
                Console.WriteLine($"Congrats! You completed the Listing activity {amountL} times!");
                Console.WriteLine("Ending Program");
                i = 0;
            }
        }
    }

    static string Menu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("[B]reating Actvity");
        Console.WriteLine("[R]eflection Activity");
        Console.WriteLine("[L]isting Activity");
        Console.WriteLine("[Q]uit program");
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }
}