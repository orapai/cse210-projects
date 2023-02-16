using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Pencil", "123abc", 2, 4, 
        "Daisy Dee", "123 Main street", "Phoenix", "Arizona", "USA");
        order1.AddNewProduct("Eraser", "124abd", 1, 2);
        order1.AddNewProduct("Lunch Box", "125abe", 15, 2);
        order1.DisplayOrderInfo();
        Order order2 = new Order("Paper", "126abf", 8, 3, 
        "Johnny Uy", "123 First street", "Montreal", "Quebec", "Canada");
        order2.AddNewProduct("Umbrella", "127abg", 35, 1);
        order2.AddNewProduct("Shoes", "128abh", 55, 1);
        order2.DisplayOrderInfo();
    }
}