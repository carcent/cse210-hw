using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2023 SW East St", "Springfield", "IL", "USA");
        Address address2 = new Address("3081 CR 865", "Alvin", "TX", "USA");
        Address address3 = new Address("Perata 2936", "Quilmes", "Buenos Aires", "Argentina");
        Address address4 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Susan Sikes", address1);
        Customer customer2 = new Customer("Sam Morrill", address2);
        Customer customer3 = new Customer("Mariano Palermo", address3);
        Customer customer4 = new Customer("Jaque Lecofier", address4);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("screen", "W15645423", 100.00m, 2));
        order1.AddProduct(new Product("mouse", "G456213", 15.00m, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keypad", "T765489", 20.00m, 1));
        order2.AddProduct(new Product("Mouse", "G456213", 15.00m, 1));
        order2.AddProduct(new Product("Screen", "W06546512", 115.00m, 1));
        
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("screen", "W01588789", 120.00m, 1));
        order3.AddProduct(new Product("Keyboard", "D01265465", 5.00m, 1));
        order3.AddProduct(new Product("video games", "V54645012", 15.00m, 2));

        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("screen", "W15645423", 100.00m, 2));
        order4.AddProduct(new Product("mouse", "G456213", 15.00m, 1));
        
        
      
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order1.CalculateTotal():C}\n~");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order2.CalculateTotal():C}\n~");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order3.CalculateTotal():C}\n~");

        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order4.CalculateTotal():C}\n~");
    }

}