using System;

public class ListingActivity : Activity
{
    private List<string> answers = new List<string>();
    private List<string> _prompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

     public ListingActivity() : base()
    {
        SetActivityNameAndDescription("Listing Activity", "This activity will help you " + 
        "reflect on the god things in your life by having you list as many things as " + 
        "you can on a certain area.");
    }
     public void StartListingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetPrompt(_prompt, "list")} ---");
        Console.Write("You may begin in: ");
        DisplayCounter(5);
        Console.WriteLine();
        int spinnerCount = GetDuration();
        int i = 0;    
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(spinnerCount/2);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            answers.Add(answer);
            currentTime = DateTime.Now;
            i++;
        }
        Console.WriteLine($"You listed {i} items!");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt(_prompt, "list")} ---");
        Console.Write("You may begin in: ");
        DisplayCounter(5);
        Console.WriteLine();
        spinnerCount = GetDuration();
        i = 0;    
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(spinnerCount/2);
        currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write(">");
            string answer = Console.ReadLine();
            answers.Add(answer);
            currentTime = DateTime.Now;
            i++;
        }
        Console.WriteLine($"You listed {i} items!");
        Console.WriteLine();
        EndMessage();
    }
}