using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "N123", 3.00, 5));
        order1.AddProduct(new Product("Pen", "P456", 1.50, 10));
        order1.AddProduct(new Product("Backpack", "B789", 25.00, 1));

        // Order 2
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Lee", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", "W321", 10.00, 2));
        order2.AddProduct(new Product("Planner", "P654", 7.50, 1));

        // Display Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));

        // Display Order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}