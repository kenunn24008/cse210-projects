using System;

class Program
{
    static void Main(string[] args) {
        // Console.Write("What is the magic number: ");
        // string temp = Console.ReadLine();
        // int magic = int.Parse(temp);
        Random random = new Random();
        int magic = random.Next(1, 101);
        int numguess = 0;

        string guessed = "no";
        while (guessed == "no") {
            Console.Write("What is your guess? ");
            string temp1 = Console.ReadLine();
            int guess = int.Parse(temp1);
            if (guess > magic){
                Console.WriteLine("Lower");
                numguess++;
            }
            if (guess < magic){
                Console.WriteLine("Higher");
                numguess++;
            }
            if (guess == magic){
                Console.WriteLine("You guessed it!");
                numguess++;
                guessed = "yes";
            }
        }
        Console.WriteLine($"You had {numguess} guesses!");


    }
}