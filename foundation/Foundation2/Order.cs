using System.Text;

namespace Foundation2;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(string name, string productId, decimal price, int quantity)
    {
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }
    
    public string CalcTotalCost()
    {
        bool isResident = _customer.IsUsaResident();
        decimal shipCost;
        if (isResident)
        {
            shipCost = 5.00m;
        }
        else
        {
            shipCost = 35.00m;
        }
        
        decimal total = 0.00m;
        foreach (Product product in _products)
        {
            total += product.CalcCost();
        }
        total += shipCost;
        return ($"${total.ToString()}");
    }

    public string GetPackingLabel()
    {
        StringBuilder packLabel = new StringBuilder();
        foreach (Product product in _products)
        {
            packLabel.AppendLine(product.GetProductString());
        }
        return packLabel.ToString();
    }

    public string GetShipLabel()
    {
        string shipLabel = _customer.GetShipString();
        return shipLabel;
    }
}