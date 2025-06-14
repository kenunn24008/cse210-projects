using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) 
    :base (name, description, duration)
    {
        
    }
    public static void Run(int duration)
    {
        int reps = duration / 10;
        for (int i = 1; i <= reps; i++)
        {
            Activity.Countdown(5, "Breath In... ");
            Activity.Countdown(5, "Breath Out... ");
        }
    }
}