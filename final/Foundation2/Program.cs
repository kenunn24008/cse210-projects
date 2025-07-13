using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 4 Project");

        Address address1 = new Address("510 S Center St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Bro Barzee", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Expensive Laptop", "PROD001", 9999.99, 1),
            new Product("White board markers", "PROD002", 2.50, 30),
            new Product("Keyboard", "PROD003", 75.00, 1)
        };

        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}\n");

        Address address2 = new Address("456 fake Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Blinker Fluid", "PROD004", 150.00, 2),
            new Product("Gift card for Nigerian Prince", "PROD005", 80.00, 1)
        };

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}