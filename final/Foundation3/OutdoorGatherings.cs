using System;

public class OutdoorGatherings : Events
{
    private string _weatherForecast;

    public OutdoorGatherings(string eventType, string eventTitle, string eventDescription, string date, 
    string time, string streetAddress, string city, string state, string country, string weatherForecast) 
    : base(eventType, eventTitle, eventDescription, date, time, streetAddress, city, state, country)
    {
        _weatherForecast = weatherForecast;
    }
    public void DisplayOutdoorGatheringFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Weather Forecast is {_weatherForecast}.");
    }
}