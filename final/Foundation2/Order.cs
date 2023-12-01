using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int tableWidth = 73;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public int ShippinCost(){
        return _customer.LiveInUsa() ? 5 : 35;
    }

    public void TotalOrderCost()
    {
        // The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
        PrintLine();
        ConsoleColor magenta = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = magenta;
        Console.WriteLine("Total Order Cost");
        Console.ResetColor();
        PrintLine();
        PrintRow("Item", "Price");   
        PrintLine();     
        double total = 0;
        foreach (Product p in _products)
        {
            PrintRow(p.GetProductName(), $"${p.GetProductPrice()}");
            total += p.GetProductPrice();
            PrintLine();
        }
        PrintRow("Shipping Cost", $"$"+ShippinCost());
        PrintLine();
        total += ShippinCost();
        PrintRow("TOTAL", $"${total}");
        PrintLine();   
        Console.WriteLine();
    }

    public void CreatePackingLabel()
    {
        PrintLine();
        ConsoleColor yellow = ConsoleColor.Yellow;
        Console.ForegroundColor = yellow;
        Console.WriteLine("Packing Label");
        Console.ResetColor();
        PrintLine();
        PrintRow("Product Name", "#Id");
        PrintLine();
        foreach(Product p in _products)
        {
            PrintRow(p.GetProductName(),$"{p.GetProductId()}");
            PrintLine();
        }
        Console.WriteLine();
    } 

    public void CreateShippingLabel()
    {
        // A shipping label should list the name and address of the customer
        PrintLine();
        ConsoleColor blue = ConsoleColor.Blue;
        Console.ForegroundColor = blue;
        Console.WriteLine("Shipping Label");
        Console.ResetColor();
        PrintLine();
        Console.WriteLine($"Name: {_customer.GetCustomerName()}\n\n\nShip to: {_customer.GetCustomerAddress()}");
        PrintLine();
        Console.WriteLine();
    }
    
    public void PrintLine()
    {
        Console.WriteLine(new string('-', tableWidth));
    }

    public void PrintRow(params string[] columns)
    {
        int width = (tableWidth - columns.Length) / columns.Length;
        string row = "|";

        foreach (string column in columns)
        {
            row += AlignLeft(column, width) + "|";
        }

        Console.WriteLine(row);
    }

    public string AlignLeft(string text, int width)
    {
        text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

        if (string.IsNullOrEmpty(text))
        {
            return new string(' ', width);
        }
        else
        {
            //return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            return text.PadRight(width);
        }
    }
    
}