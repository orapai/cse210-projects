using System;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    private int _spinCounter = 0;

    private List<string> _list;
    private List<string> _displayedReflectionListA = new List<string>();
    private List<string> _displayedListingList = new List<string>();
    private List<string> _displayedReflectionListB = new List<string>();
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds would your like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
        Console.WriteLine();
    }
    public void DisplaySpinner(int duration)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < duration)
        {
            _spinCounter ++;
            switch(_spinCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayCounter(int duration)
    {
        for (int count = duration; count >= 1; count--)
        {
            int i = 1;
            Console.Write(count);
            Console.SetCursorPosition((Console.CursorLeft++)-i, Console.CursorTop);
            Thread.Sleep(1000);
            i++;
        }
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
        Console.Write(" ");
    }
    public void EndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        DisplaySpinner(5);
        Console.Clear();
    }
    public void SetActivityNameAndDescription(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    public string GetPrompt(List<string> lists, string listName)
    {
        _list = new List<string>();
        _list = lists;
        string name = listName;
        bool displayed = false;
        string prompt = "";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(_list.Count);
            prompt =  _list[number];        
            if (name == "reflectionA")
            {                    
                displayed = true;
            }
            if (name == "reflectionB")
            {
                if(!HasBeenDisplayed(_displayedReflectionListB, number.ToString()))
                {
                    prompt = _list[number];
                    _displayedReflectionListB.Add(number.ToString());
                    displayed = true;
                }
            }
            if (name == "list")
            {
                if(!HasBeenDisplayed(_displayedListingList, number.ToString()))
                {
                    prompt = _list[number];
                    _displayedListingList.Add(number.ToString());
                    displayed = true;
                }
            }
        }while (!displayed);
        return prompt;
    }
    public bool HasBeenDisplayed(List<string> lists, string x)
    {
        bool displayed = false;
        foreach(string num in lists)
        {
            if(lists.Contains(x))
            {
                displayed = true;
                break;
            }
        }
        return displayed;
    }
}