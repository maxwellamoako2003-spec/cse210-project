using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first customer in the USA
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Create the first order
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P101", 800, 1);
        Product product2 = new Product("Mouse", "P102", 25, 2);
        Product product3 = new Product("Keyboard", "P103", 45, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create the second customer outside the USA
        Address address2 = new Address(
            "15 Oxford Street",
            "Accra",
            "Greater Accra",
            "Ghana"
        );

        Customer customer2 = new Customer("Mary Johnson", address2);

        // Create the second order
        Order order2 = new Order(customer2);

        Product product4 = new Product("Smartphone", "P201", 500, 1);
        Product product5 = new Product("Headphones", "P202", 60, 2);
        Product product6 = new Product("Phone Case", "P203", 15, 3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Store orders in a list
        List<Order> orders = new List<Order>
        {
            order1,
            order2
        };

        // Display order information
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"========== ORDER {orderNumber} ==========");
            Console.WriteLine();

            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"TOTAL COST: ${order.CalculateTotalCost():F2}");

            Console.WriteLine("\n====================================\n");

            orderNumber++;
        }
    }
}