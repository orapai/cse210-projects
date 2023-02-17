using System;

public class Cycling : Activity
{
   private double _speed;
    
   public Cycling(string date, double activityLengthInMinutes, 
   double speed) : base(date, activityLengthInMinutes)
   {
      _speed = speed;
   }
   public double GetSpeed()
   {
      return _speed;
   }
   public double GetDistance()
   {
      return (GetLength() * 60) / GetSpeed();
   }
   public override double GetPace()
   {    
      double speed = GetSpeed();
      return 60 / speed;
   }
   public override string GetSummary()
   {
      return $"{GetDate()} Cycling ({GetDistance()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
   }
}