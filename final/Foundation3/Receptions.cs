public class Receptions : Event
{
    private string _email;

    public Receptions(string title, string description, string date, string time, Address address, string email)
    : base(title, description, date, time, address)
    {
        _email = email;
    }

    public static void DisplayReceptionStan(Receptions event1)
    {
        Event.Standard(event1);
    }

    public static void DisplayReceptionFull(Receptions event1)
    {
        Event.Standard(event1);
        Console.WriteLine("Event type: Recpetion");
        Console.WriteLine(event1._email);
    }

    public static void DisplayReceptionShort(Receptions event1)
    {
        Event.Short(event1);
        Console.WriteLine("Event Type: Reception");
    }
}