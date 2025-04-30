using System;

class Program
{
    static void Main(string[] args) {
        List<int> numbers = new List<int>();
        int tempnum = 1;
        while (tempnum != 0) {
            Console.Write("Enter a number to add to the list (Enter 0 to end list):");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num != 0) {
            numbers.Add(num);
            }
            if (num == 0) {
                tempnum = 0;
            }
        }

        int sum = 0;
        float average;
        int max = 0;

        foreach (int i in numbers) {
            sum += i;
        }
    
        average = sum / numbers.Count;

        foreach (int i in numbers) {
            if (i > max) {
                max = i;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"The max is: {max}");
        








    }
}