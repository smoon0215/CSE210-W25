using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "London", "", "UK");

        // Create Customers
        Customer customer1 = new Customer("Alice Smith", address1);
        Customer customer2 = new Customer("Bob Johnson", address2);

        // Create Products
        Product product1 = new Product("Laptop", "LP123", 1200.0, 1);
        Product product2 = new Product("Mouse", "MS456", 25.0, 2);
        Product product3 = new Product("Keyboard", "KB789", 50.0, 1);
        Product product4 = new Product("Headphones", "HP101", 100.0, 1);
        Product product5 = new Product("Charger", "CH202", 30.0, 3);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1 Information
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order 1 Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        // Display Order 2 Information
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order 2 Cost: ${order2.GetTotalCost()}");
    }
}