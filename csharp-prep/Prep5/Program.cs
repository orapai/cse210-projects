using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        DisplayResult(name, num);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string number = Console.ReadLine();
        int x = int.Parse(number);
        x = SquareNumber(x);
        return x;
    }
    static int SquareNumber(int y)
    {
        int squared = y * y;
        Console.WriteLine(squared);
        return squared;
    }
    static void DisplayResult(string x, int y)
    {
        Console.WriteLine($"{x}, the square of your number is {y}");
    }
}