using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // create customers
        Customer customer1 = new Customer("Howard Henson", "321 New Street", "Reem Island", "Abu Dhabi", "UAE");
        Customer customer2 = new Customer("Michael Wimpey", "202 Spring Road", "Raleigh", "North Carolina", "USA");
        Customer customer3 = new Customer("Desiree Yang", "345 Macie Road", "Suitland", "Maryland", "USA");
        
        // create orders
        Order order1 = new Order(customer1);
        order1.AddProduct("Apple", "App005", 0.45m, 6);
        order1.AddProduct("Eggs", "Egg254", 3.98m, 1);
        order1.AddProduct("Bananas", "Ban109", 0.75m, 5);
        order1.AddProduct("Bread", "Bre620", 1.29m, 2);
        order1.AddProduct("Cheese", "Che050", 7.50m, 1);
        orders.Add(order1);
        
        Order order2 = new Order(customer2);
        order2.AddProduct("Shampoo", "Sha025", 9.99m, 1);
        order2.AddProduct("Shower Gel", "Gel118", 11.99m, 1);
        order2.AddProduct("Toothpaste", "Too543", 5.68m, 3);
        orders.Add(order2);
        
        Order order3 = new Order(customer3);
        order3.AddProduct("Water", "Wat541", 0.50m, 12);
        order3.AddProduct("Toiletpaper", "Toi987", 8.47m, 2);
        order3.AddProduct("Catfood", "Cat123", 2.35m, 24);
        order3.AddProduct("Chocolate", "Cho876", 1.25m, 1);
        orders.Add(order3);
        
        Console.Clear();

        int i = 1;
        foreach (Order o in orders)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"------ ORDER {i} ------");
            Console.WriteLine($"Total cost: {o.CalcTotalCost()}");
            Console.WriteLine(" ");
            Console.WriteLine("Packing Label:");
            Console.WriteLine("(Qty, Product ID, Product Name)");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(o.GetShipLabel());
            i++;
        }
    }
}