using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // First order
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 45, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Second customer (Outside USA)
        Address address2 = new Address(
            "15 Oxford Street",
            "Accra",
            "Greater Accra",
            "Ghana"
        );

        Customer customer2 = new Customer("Mary Johnson", address2);

        // Second order
        Order order2 = new Order(customer2);

        Product product4 = new Product("Phone", "P004", 500, 1);
        Product product5 = new Product("Headphones", "P005", 60, 2);
        Product product6 = new Product("Charger", "P006", 20, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display first order
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();

        // Display second order
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}