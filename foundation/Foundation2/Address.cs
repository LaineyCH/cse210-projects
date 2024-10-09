using System.Text;

namespace Foundation2;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country.ToUpper();
    }
    
    public bool IsUsaResident()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public string GetAddressString()
    {
        StringBuilder addressString = new StringBuilder(); 
        addressString.AppendLine(_street);
        addressString.AppendLine(_city);
        addressString.AppendLine(_state);
        addressString.AppendLine(_country);
        return addressString.ToString();
    }
}