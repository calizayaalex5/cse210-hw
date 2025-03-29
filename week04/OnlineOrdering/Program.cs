using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering");
        Console.WriteLine();


        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99m, 2));
        order1.AddProduct(new Product("Mouse", 102, 49.99m, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetOrderSummary());

        Console.WriteLine();
        Console.WriteLine("==============================================================");
        Console.WriteLine();

        Address address2 = new Address("942 Eslavonia Str.", "Iquique", "Region Tarapaca", "Chile");
        Customer customer2 = new Customer("Mike Gonzales", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Iphone 16", 210, 899.99m, 1));
        order2.AddProduct(new Product("Ipad M4", 230, 1849.99m, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetOrderSummary());
    }
}