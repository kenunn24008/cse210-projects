public class Event
{
    private string _title;

    private string _description;

    private string _date;

    private string _time;

    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public static void Standard(Event event1)
    {
        Console.WriteLine($"Title: {event1._title}");
        Console.WriteLine($"Description: {event1._description}");
        Console.WriteLine($"Date: {event1._date}");
        Console.WriteLine($"Time: {event1._time}");
        Address.DisplayAddress(event1._address);

    }

    public static void Short(Event event1)
    {
        Console.WriteLine(event1._title);
        Console.WriteLine(event1._date);
    }
}