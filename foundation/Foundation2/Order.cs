using System;
using Microsoft.VisualBasic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order (Customer customer)
    {
        _products = new List<Product>();
        customer = _customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotal()
    {
        decimal totalPrice = 0;
        decimal shippingCost;

        if (Customer.InsideUsa())
        {
            shippingCost = 5.00m;
        }
        else 
        {
            shippingCost = 35.00m;
        }

        foreach (var product in _products)
        {
            totalPrice += product.TotalCost();
        }

        return totalPrice + shippingCost;
        
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
    }



}