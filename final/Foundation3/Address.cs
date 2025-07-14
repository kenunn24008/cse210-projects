public class Address
{
    private int _number;

    private string _street;

    private string _city;

    private string _state;

    private string _country;

    public Address(int number, string street, string city, string state, string country)
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public static void DisplayAddress(Address address)
    {
        Console.WriteLine($"Address: {address._number} {address._street}, {address._city}, {address._state}, {address._country}");
    }    
}