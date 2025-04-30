using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favnum = PromptUserNumber();
        int squared = SquareNumber(favnum);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int number) {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int squared) {
        Console.WriteLine($"{name}, the square of your number is: {squared}");
    }


}