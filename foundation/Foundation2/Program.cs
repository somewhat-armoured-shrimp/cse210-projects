using System;

class Program
{
    static void Main(string[] args)
    {
        // first order
        // YOUR VALIDITY IS DEPENDENT ON WHETHER OR NOT YOU HAVE A STATE HAHAHAHAAAA smiling devil emoji
        Address address1 = new Address("56 St Andrew's Rd", "Cambridge", "", "England");
        Customer customer1 = new Customer("Wendy's Guy", address1);
        List<Product> products1 = new List<Product>();

        // reminder: in the beginning, create an instance of the  
        // class with the most information from other classes
        // to help find and force you to create the information needed 
        Order order1 = new Order(customer1, products1);

        products1.Add(new Product("Canned Beans", 362313, 100000.00m, 1)); // inflation is crazy
        products1.Add(new Product("Horse", 837482, 4.99m, 1));

        // second order
        Address address2 = new Address("78 People Blood Rd", "Gary", "Indiana", "USA");
        Customer customer2 = new Customer("Mario Pitario", address2);
        List<Product> products2 = new List<Product>();

        Order order2 = new Order(customer2, products2);

        products2.Add(new Product("Dish Soap", 777332, 8.99m, 2));
        products2.Add(new Product("Bar Soap", 319312, 4.99m, 6));
        products2.Add(new Product("KitchenAid Electric Mixer", 100001, 279.99m, 1));


        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total: ${order1.CalculateShippingCost()}\n----------------------------------------"); // who cares anymore

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total: ${order2.CalculateShippingCost()}\n----------------------------------------");



    }
}