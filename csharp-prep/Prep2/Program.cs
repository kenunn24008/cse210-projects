using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float percent = float.Parse(grade);
        string letgrade = "";
        if (percent >= 90) {
            letgrade = "A";
        }
        else if (percent >= 80) {
            letgrade = "B";
        }
        else if (percent >= 70) {
            letgrade = "C";
        }
        else if (percent >= 60) {
            letgrade = "D";
        }
        else if (percent < 60) {
            letgrade = "F";
        }
        
        Console.WriteLine($"Your grade is {letgrade}.");

        if (percent >= 70) {
            Console.WriteLine("Congrats you passed the class!");
        }
        else {
            Console.WriteLine("You failed, better luck next time!");
        }

        

    }
}

/* 
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/