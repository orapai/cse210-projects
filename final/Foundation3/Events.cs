using System;

public class Events
{
    private string _eventTitle;
    private string _eventDescription;
    private string _date;
    private string _time;
    private string _eventType;
    private EventAddress _address;

    public Events()
    {
    }
    public Events(string eventType, string eventTitle, string eventDescription, string date, string time, string streetAddress,
    string city, string state, string country)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _time = time;
        _address = new EventAddress(streetAddress, city, state, country);
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"\n{_eventTitle}\n{_eventDescription}" +
        $"\n{_date}, {_time}\n{_address.GetCompleteAddress()}");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_eventType}: \n{_eventTitle} on {_date}");
    }
}