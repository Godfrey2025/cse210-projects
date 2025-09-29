using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (USA customer)
        Address address1 = new Address("2053 Eastview Road", "Texas", "TX", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS2002", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Second order (International customer)
        Address address2 = new Address("6 Tondoro Street New Mabvuku", "Harare", "HRE", "Zimbabwe");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "TB3003", 499.99, 1));
        order2.AddProduct(new Product("Stylus", "ST4004", 39.99, 1));
        order2.AddProduct(new Product("Case", "CS5005", 19.99, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
