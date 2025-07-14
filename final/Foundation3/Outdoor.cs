public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather)
    : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public static void DisplayOutdoorStan(Outdoor event1)
    {
        Event.Standard(event1);
    }

    public static void DisplayOutdoorFull(Outdoor event1)
    {
        Event.Standard(event1);
        Console.WriteLine("Event type: Outdoor");
        Console.WriteLine($"Weather Statement: {event1._weather}");
    }

    public static void DisplayOutdoorShort(Outdoor event1)
    {
        Event.Short(event1);
        Console.WriteLine("Event Type: Outdoor");
    }
}