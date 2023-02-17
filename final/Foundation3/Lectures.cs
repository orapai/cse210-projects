using System;

public class Lectures : Events
{
    private string _speaker;
    private int _limitedCapacity;

    public Lectures(string eventType, string eventTitle, string eventDescription, string date, 
    string time, string streetAddress,
    string city, string state, string country, string speaker, int limitedCapacity) : base(eventType, eventTitle, 
    eventDescription, date, time, streetAddress, city, state, country)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;
    }
    public void DisplayLectureFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Speaker for this event is {_speaker}.");
        Console.WriteLine($"Only {_limitedCapacity} seats are available so first come first serve!");
    }

}