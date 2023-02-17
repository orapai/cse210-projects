using System;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    
    public Order()
    {
    }
    public Order(string productName, string productID, int price, 
    int quantity, string customerName, string streetAddress,
    string city, string state, string country)
    {
        Product product = new Product(productName, productID, price, quantity);
        _productList.Add(product);
        _customer = new Customer(customerName, streetAddress,
        city, state, country);
    }
    public void AddNewProduct(string productName, string productID, int price, 
    int quantity)
    {
        Product product = new Product(productName, productID, price, quantity);
        _productList.Add(product);
    }
    public void DisplayOrderInfo()
    {
        Console.WriteLine($"\nPacking Label:\n{PackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{ShippingLabel()}");
        Console.WriteLine($"\nTotal Price:\n${CalculateOrderCost()}");
    }
    public int CalculateOrderCost()
    {
        int totalOrderCost = 0;
        foreach(Product product in _productList)
        {
            totalOrderCost += product.GetPrice();
        }
        if(_customer.NotInUsa() == true)
        {
            totalOrderCost += 35;
        }
        else if(_customer.NotInUsa() == false)
        {
            totalOrderCost += 5;
        }
        return totalOrderCost;
    }
    public string PackingLabel()
    {
        string list = "";
        foreach(Product product in _productList)
        {
            string packingLabel = product.GetPackingLabel();
            list = $"{list}{packingLabel}\n";
        }
        return list;
    }
    public string ShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}