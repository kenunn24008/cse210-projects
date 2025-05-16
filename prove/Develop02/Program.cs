using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Journal Program!");
        int quit = 0;
        while (quit == 0)
        {
            string userChoice;
            userChoice = Menu();
            if (userChoice == "L")
            {
                Console.Write("Enter the filename of the journal you want to load: ");
                string load = Console.ReadLine();
                Load(load);
            }
            if (userChoice == "D")
            {
                Display();
            }
            if (userChoice == "W")
            {
                Write();
            }
            if (userChoice == "S")
            {
                Save();
            }
            if (userChoice == "C")
            {
                quit = 1;
            }
        }
    }


    static string Menu()
    {
        string input;
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("[L]oad a journal");
        Console.WriteLine("[D]isplay the current journal");
        Console.WriteLine("[W]rite a new entry");
        Console.WriteLine("[S]ave the current jounral");
        Console.WriteLine("[C]lose");
        Console.Write("Enter a command: ");

        input = Console.ReadLine();
        return input;
    }

    static void Load(string args)
    {
        String line;
        try
        {
            StreamReader sr = new StreamReader(args + ".txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    public static void Display(){
        journal book1 = new();
        journal.Display();
    }

    public static void Write()
    {
        Console.Write("Enter the date: ");
        string date = Console.ReadLine();
        string pickedprompt = promptGenerator();
        Console.WriteLine(pickedprompt);
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        entry entry1 = new();
        entry1._date = date;
        entry1._prompt = pickedprompt;
        entry1._response = response;

        journal book1 = new();
        journal._temp.Add(entry1);

    }

    public static void Save()
    {
        Console.Write("Enter the name of your journal: ");
        string name = Console.ReadLine();
        journal.saveEntry(name);
    }

    static string promptGenerator() {
        List<string> prompts = new List<string>();
        prompts.Add("What was the best part of your day?");
        prompts.Add("What did you eat for lunch today?");
        prompts.Add("What was the hardest part of your day?");
        prompts.Add("What was the funnest part of the day?");
        prompts.Add("What did you learn from the scriptures today?");
        Random rnd = new Random();
        int pick  = rnd.Next(0, prompts.Count);
        return prompts[pick];
    }
}