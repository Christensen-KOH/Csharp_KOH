using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("1525 Plateau Dokui", "Abidjan", "Abidjan", "Cote D'Ivoire");
        Customer customer1 = new Customer("Navigue Traore", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 19.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-205", 8.50, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-310", 34.00, 1));
        orders.Add(order1);

        Address address2 = new Address("45 Rue de Rivoli", "Paris", "Ile-de-France", "France");
        Customer customer2 = new Customer("Jean-Jacque Kouame", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-450", 79.95, 1));
        order2.AddProduct(new Product("Monitor Light Bar", "ML-220", 25.00, 2));
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            double total = order.CalculateTotalCost();
            Console.WriteLine($"Total Price: ${total:0.00}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}
