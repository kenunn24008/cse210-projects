public class Lectures : Event
{
    private string _speaker;

    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public static void DisplayLectureStan(Lectures event1)
    {
        Event.Standard(event1);
    }

    public static void DisplayLectureFull(Lectures event1)
    {
        Event.Standard(event1);
        Console.WriteLine("Event type: Lecture");
        Console.WriteLine($"Speaker: {event1._speaker}");
        Console.WriteLine($"Capacity: {event1._capacity}");
    }

    public static void DisplayLectureShort(Lectures event1)
    {
        Event.Short(event1);
        Console.WriteLine("Event Type: Lecture");
    }
}