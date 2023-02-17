using System;

public class Swimming : Activity
{
   private double _numOfLaps; //50 meters length in lap pool

   public Swimming(string date, double activityLengthInMinutes, 
   double numOfLaps) : base(date, activityLengthInMinutes)
   {
      _numOfLaps = numOfLaps;
   }
   public double GetDistance()
   {
      return _numOfLaps * 50 / 1000;
   }
   public double GetSpeed()
   {
      return GetLength() / GetDistance();
   }
   public override double GetPace()
   {
      double speed = GetSpeed();
      return 60 / speed;
   }
   public override string GetSummary()
   {
      return $"{GetDate()} Swimming ({GetDistance()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
   }
}