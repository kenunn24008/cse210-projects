using System;

class Program
{
    static void Main(string[] args)
    // (),(void is the return type),(Main is the name of the function),(string[] is the data type) 
    // Main in required in C#, case sensitive
    {
        // get the radius of a circle from the user
        Console.Write("Please enter the radius: ");
        string text = Console.ReadLine();
        double radius = double.Parse(text);

        // compute area of circle
        double area = Math.PI * radius * radius;

        // display the area for the user to see
        Console.WriteLine($"Area of the circle: {area}");

        int x = 3;
        string s = "Goodbye";
        float f = 3.14F;    // "F" is needed to tell the compiler to treat 3.14 as a float isntead of a double
        double d = 5.21;
        long n = 25;

        Console.WriteLine($"Hello, {s} Sandbox World! {x} {f} {d}");
    }
}