using System;
using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InsideUsa()
    {
        return _address.InsideUsa();
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;

}