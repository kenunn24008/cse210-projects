using System;
using System.ComponentModel.Design;

public class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        userChoice = Menu();

        if (userChoice == "1")
        {
            Reference scriptureReference = new Reference("1 Nephi", 3, 7);
            string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            Scripture scriptureToMemorize = new Scripture(scriptureReference, scriptureText);
            int wordsToHidePerTurn = 3;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scriptureToMemorize.GetDisplayText());

                if (scriptureToMemorize.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words have been hidden!");
                    break;
                }

                Console.WriteLine($"\nPress Enter to hide {wordsToHidePerTurn} more word(s), or type 'quit' to end.");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit")
                {
                    Console.WriteLine("Ending Program.");
                    break;
                }
                else
                {
                    scriptureToMemorize.HideRandomWords(wordsToHidePerTurn);
                }
            }
        }
        if (userChoice == "2")
        {
            Reference scriptureReference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            Scripture scriptureToMemorize = new Scripture(scriptureReference, scriptureText);
            int wordsToHidePerTurn = 3;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scriptureToMemorize.GetDisplayText());

                if (scriptureToMemorize.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words have been hidden!");
                    break;
                }

                Console.WriteLine($"\nPress Enter to hide {wordsToHidePerTurn} more word(s), or type 'quit' to end.");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit")
                {
                    Console.WriteLine("Ending Program.");
                    break;
                }
                else
                {
                    scriptureToMemorize.HideRandomWords(wordsToHidePerTurn);
                }
            }
        }
        if (userChoice == "3")
        {
            Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.; In all thy ways acknowledge him, and he shall direct thy paths.";
            Scripture scriptureToMemorize = new Scripture(scriptureReference, scriptureText);
            int wordsToHidePerTurn = 3;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scriptureToMemorize.GetDisplayText());

                if (scriptureToMemorize.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words have been hidden!");
                    break;
                }

                Console.WriteLine($"\nPress Enter to hide {wordsToHidePerTurn} more word(s), or type 'quit' to end.");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit")
                {
                    Console.WriteLine("Ending Program.");
                    break;
                }
                else
                {
                    scriptureToMemorize.HideRandomWords(wordsToHidePerTurn);
                }
            }
        }
    }

    static string Menu()
    {
        string userChoice;
        Console.Clear();
        Console.WriteLine("Welcome to the scripute Program!");
        Console.WriteLine("Select a scriputre to memorize:");
        Console.WriteLine("1. 1 Nephi 3:7");
        Console.WriteLine("2. John 3:16");
        Console.WriteLine("3. Proverbs 3:5-6");
        userChoice = Console.ReadLine();
        return userChoice;
    }
}