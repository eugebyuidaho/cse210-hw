using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1396 Parkside Dr", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("Eugenia Schulz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Photo Album", "001", 5.50, 2));
        order1.AddProduct(new Product("Chalk Paint", "264", 3.25, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalCost():C}");
        Console.WriteLine();

        Address address2 = new Address("1245 Rivadavia Avenue", "Resistencia", "Chaco", "Argentina");
        Customer customer2 = new Customer("Federico Caceres", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "367", 2.50, 5));
        order2.AddProduct(new Product("Watercolors", "855", 6.75, 6));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalCost():C}");
        Console.WriteLine();
    }
}