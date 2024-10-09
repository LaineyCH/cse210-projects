using System.Text;

namespace Foundation2;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }
    public bool IsUsaResident()
    {
        return _address.IsUsaResident();
    }

    public string GetShipString()
    {
        StringBuilder shippingString = new StringBuilder(); 
        shippingString.AppendLine(_name.ToUpper());
        shippingString.AppendLine(_address.GetAddressString());
        return shippingString.ToString();
    }
}