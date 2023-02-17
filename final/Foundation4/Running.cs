using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, double activityLengthInMinutes, 
    double distance) : base(date, activityLengthInMinutes)
    {
        _distance = distance;
    }    
    public double GetDistance()
    {
        return _distance;
    }
    public double GetSpeed()
    {
        double length =  GetLength();
        return _distance / length;
    }
    public override double GetPace()
    {
        double speed = GetSpeed();
        return 60 / speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDistance()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
} 