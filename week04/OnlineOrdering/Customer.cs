using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerInfo()
    {
       return $"Custome: {_name}\nAddress: {_address.GetAddress()}";
    }

    public string GetCustomerName() => _name;

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}