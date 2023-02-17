using System;

public class AllActivities
{
   private List<Activity> _allActivities = new List<Activity>();

   public void Add(Activity activity)
   {
      _allActivities.Add(activity);
   }
   public void DisplayActivities()
   {
      foreach(Activity activity1 in _allActivities)
        {
            Console.WriteLine($"{activity1.GetSummary()}");
        }
   }
}