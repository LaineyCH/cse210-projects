using System.Text;

namespace Foundation2;

public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;
    
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalcCost()
    {
        return _price * _quantity;
    }

    public string GetProductString()
    {
        return ($"{_quantity} {_productId} {_name}");
    }
}