using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (USA)
        Address addr1 = new Address("123 Temple Road", "Idaho", "UT", "USA");
        Customer cust1 = new Customer("Samuel Young", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        // Second Order (Outside USA)
        Address addr2 = new Address("10 Accra St.", "Ghana", "N/A", "GH");
        Customer cust2 = new Customer("Phidelia Boateng", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Phone", "P003", 800, 1));
        order2.AddProduct(new Product("Charger", "P004", 20, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine("\n------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}