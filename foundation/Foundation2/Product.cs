using System;

class Product
{
    private string _name;
    private string _productId;
    private decimal _price;

    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        name = _name;
        productId = _productId;
        price = _price;
        quantity = _quantity;
    }

    public decimal TotalCost()
    {
        return _price *_quantity;
    }

    public string GetProductDetails()
    {
        return $"Product: {_name} (ID:{_productId}- Quantity: {_quantity}, Price: {_price:C}, Total: {TotalCost():C}";
    }

    public string ProductId => _productId;

}