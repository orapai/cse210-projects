using System;

public class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product()
    {
    }
    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public int GetPrice()
    {
        int totalPrice = 0;
        return totalPrice = _price * _quantity; 
    }
    public string GetPackingLabel()
    {
        return $"Product name:{_name}, Product ID: {_productID}";
    }
}