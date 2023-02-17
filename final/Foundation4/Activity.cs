using System;

public abstract class Activity
{
    private string _date;
    private double _activityLengthInMinutes;

    public Activity()
    {
    }
    public Activity(string date, double activityLengthInMinutes)
    {
        _date = date;
        _activityLengthInMinutes = activityLengthInMinutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _activityLengthInMinutes;
    }
    public abstract double GetPace();
    public abstract string GetSummary();
}