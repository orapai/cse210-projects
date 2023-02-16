using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {
    }
    public Customer(string customerName, string streetAddress,
    string city, string state, string country)
    {
        _name = customerName;
        _address = new Address(streetAddress, city, state, country);
    }

    public string GetShippingLabel()
    {
        return $"{_name} \n{ _address.GetCompleteAddress()}";
    }
    public Boolean NotInUsa()
    {
        return _address.IsNotInUsa();
    } 
}