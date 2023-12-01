public class Product
{
    // Contains the name, product id, price, and quantity of each product.
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;
    
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName(){
        return _name;
    }

    public int GetProductId(){
        return _id;
    }

    public double GetProductPrice(){ 
        return _price * _quantity;;
    }
    
}