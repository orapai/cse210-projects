using System;

public class Receptions : Events
{
    private string _reservationEmail;

    public Receptions(string eventType, string eventTitle, string eventDescription, string date, string time, string streetAddress,
    string city, string state, string country, string reservationEmail) : base(eventType, eventTitle, 
    eventDescription, date, time, streetAddress, city, state, country)
    {
        _reservationEmail = reservationEmail;
    }
    public void DisplayReceptionFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Please send us an email at {_reservationEmail} for a reservation.");
    }
}