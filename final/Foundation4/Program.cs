using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 4 Project");

        List<Activity> activities = [];

        Running running1 = new Running("7/16/25", 0.5, 3);
        activities.Add(running1);
        Cycling cycling1 = new Cycling("7/17/25", 2, 50);
        activities.Add(cycling1);
        Swimming swimming1 = new Swimming("7/18/25", 0.5, 15);
        activities.Add(swimming1);


        foreach (Activity i in activities)
        {
            Console.WriteLine(i.GetSummary(i));
        }

    }
}