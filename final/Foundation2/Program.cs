using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!\n");

        // Order 1
        Address a1 = new Address("W 2600 N St","Corinne","Provo","Utah","USA");
        Customer c1 = new Customer("Joe Martin",a1);
        List<Product> lp1 = new List<Product>();
        Product p1 = new Product("Fitbit Charge 6 Fitness Tracker",362,99.95,10);
        lp1.Add(p1);
        Product p12 = new Product("Countertop Microwave Oven",659,89.99,1);
        lp1.Add(p12);
        Product p13 = new Product("Mini Airfryer",252,44.99,2);
        lp1.Add(p13);
        Order o1 = new Order(lp1,c1);
        Console.Clear();
        o1.CreatePackingLabel();
        o1.CreateShippingLabel();
        o1.TotalOrderCost();

        // Order 2
        Address a2 = new Address("Jose Marmol 1670","San Rafael","Mendoza","Mendoza","Argentina");
        Customer c2 = new Customer("Martin Quintero",a2);
        List<Product> lp2 = new List<Product>();
        Product p21 = new Product("Certified Refurbished Fire 7 tablet",548,69.98,3);
        lp2.Add(p21);
        Product p22 = new Product("Motorola Moto G 5G",1524,159.99,1);
        lp2.Add(p22);
        Product p23 = new Product("40-inch D-Series Full HD 1080p Smart TV",555,168,2);
        lp2.Add(p23);
        Product p24 = new Product("Philips Sonicare 4100 Power Toothbrush",854,29.96,5);
        lp2.Add(p24);
        Order o2 = new Order(lp2,c2);
        o2.CreatePackingLabel();
        o2.CreateShippingLabel();
        o2.TotalOrderCost();

    }
}