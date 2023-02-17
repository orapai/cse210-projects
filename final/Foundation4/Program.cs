using System;

class Program
{
    static void Main(string[] args)
    {
        AllActivities activities = new AllActivities();
        Activity activity;

        activity = new Running("16 Feb 2023", 30, 5);
        activities.Add(activity);
        activity = new Cycling("23 Jan 2023", 30, 5);
        activities.Add(activity);
        activity = new Swimming("18 Jan 2023", 30, 5);
        activities.Add(activity);
        
        activities.DisplayActivities();
    }
}