using System;
using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        name = _name;
        address = _address;
    }

    public bool InsideUsa(Address InsideUsa)
    {
        return _address.InsideUsa();
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;

}