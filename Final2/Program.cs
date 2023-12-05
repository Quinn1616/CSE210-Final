class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Product 1", 123, 10, 1);
        Product product2 = new Product("Product 2", 234, 15, 2);
        Address address1 = new Address("123 Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Customer 1", address1);

        Order order1 = new Order(customer1);
        order1.Products.Add(product1);
        order1.Products.Add(product2);
        
        Console.WriteLine("Order final cost: ");
        Console.WriteLine($"${order1.CalculateFinalCost()}\n");

        Console.WriteLine("Shipping label order: ");
        Console.WriteLine($"{order1.GetShippingLabel()}\n");

        Console.WriteLine("Packing order: ");

        foreach (var item in order1.GetPackingLabel())
        {
            Console.WriteLine($"{item} ");
        }

        Console.WriteLine("\n");

        Product product3 = new Product("Product 3", 345, 10, 2);
        Product product4 = new Product("Product 4", 456, 15, 1);
        Address address2 = new Address("234 Street", "Toronto", "Ontario", "CAN");
        Customer customer2 = new Customer("Customer 2", address2);

        Order order2 = new Order(customer2);
        order2.Products.Add(product3);
        order2.Products.Add(product4);

        Console.WriteLine("Order final cost: ");
        Console.WriteLine($"{order2.CalculateFinalCost()}\n");

        Console.WriteLine("Shipping label order: ");
        Console.WriteLine($"{order2.GetShippingLabel()}\n");

        Console.WriteLine("Packing order: ");
        
        foreach (var item in order2.GetPackingLabel())
        {
            Console.Write($"{item}\n");
        }
    }
}
