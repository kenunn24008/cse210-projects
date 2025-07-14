using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 3 Project");

        // Event 1
        string title = "title1";
        string description = "description1";
        string date = "June 10th 2020";
        string time = "6:00pm";
        Address address = new Address(938, "Oak ave", "Rexburg", "ID", "USA");
        string email = "example@example.com";
        Receptions event1 = new Receptions(title, description, date, time, address, email);

        Console.WriteLine("Standard: ");
        Receptions.DisplayReceptionStan(event1);
        Console.WriteLine("\nFull: ");
        Receptions.DisplayReceptionFull(event1);
        Console.WriteLine("\nShort: ");
        Receptions.DisplayReceptionShort(event1);
        Console.WriteLine();


        // Event 2
        title = "title2";
        description = "description2";
        date = "June 11th 2020";
        time = "7:00pm";
        Address address1 = new Address(388, "Birch ave", "Rigby", "ID", "USA");
        string speaker = "speaker";
        int capacity = 1000;
        Lectures event2 = new Lectures(title, description, date, time, address, speaker, capacity);

        Console.WriteLine("Standard: ");
        Lectures.DisplayLectureStan(event2);
        Console.WriteLine("\nFull: ");
        Lectures.DisplayLectureFull(event2);
        Console.WriteLine("\nShort: ");
        Lectures.DisplayLectureShort(event2);
        Console.WriteLine();


        // Event 3
        title = "title3";
        description = "description3";
        date = "June 12th 2020";
        time = "8:00pm";
        Address address2 = new Address(388, "Birch ave", "Rigby", "ID", "USA");
        string weather = "rain idk";
        Outdoor event3 = new Outdoor(title, description, date, time, address, weather);

        Console.WriteLine("Standard: ");
        Outdoor.DisplayOutdoorStan(event3);
        Console.WriteLine("\nFull: ");
        Outdoor.DisplayOutdoorFull(event3);
        Console.WriteLine("\nShort: ");
        Outdoor.DisplayOutdoorShort(event3);
    }
}