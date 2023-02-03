using System;

public class BreathingActivity : Activity
{
     public BreathingActivity() : base()
    {
        SetActivityNameAndDescription("Breathing Activity", "This activity will help relax " + 
        "by walking you through breathing in and out slowly. Clear your mind and focus on " + 
        "your breathing.");
    }
    public void StartBreathingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine();
        Console.Write("Breathe in... ");
        DisplayCounter(3);
        Console.WriteLine();
        Console.Write("Now breathe out... ");
        DisplayCounter(5);
        Console.WriteLine();
        int spinnerCount = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(spinnerCount-8);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            BreatheIn();
            BreatheOut();
            currentTime = DateTime.Now;
            Console.WriteLine();
        }
        Console.WriteLine();
        EndMessage();
    }
    public void BreatheIn()
    {
        Console.WriteLine();
        Console.Write("Breathe in... ");
        DisplayCounter(4);
    }
    public void BreatheOut()
    {
        Console.WriteLine();
        Console.Write("Now breathe out... ");
        DisplayCounter(6);
    }

}
