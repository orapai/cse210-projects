using System;

public class ReflectingActivity : Activity
{
    private List<string> _startPrompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity() : base()
    {
        SetActivityNameAndDescription("Reflecting Activity", "This activity will help you on " + 
        "times in your life when you have shown strength and resilience. This will help you " + 
        "recognize the power you have and how you can use it in other aspects of your life.");
    }
    public void StartReflectingActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetPrompt(_startPrompt,"reflectionA")} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        DisplayCounter(3);
        Console.Clear();
        int spinnerCount = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(spinnerCount);
        int question = 8;
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime && question != 0) //not all reflection question has been displayed and time is not yet done
        {
            Console.Write($"> {GetPrompt(_reflectQuestions, "reflectionB")} ");
            DisplaySpinner(10);
            Console.WriteLine();
            question --;
            currentTime = DateTime.Now;
        }
        if(currentTime > futureTime || question == 0)
        {
            currentTime = futureTime;
        }
        Console.WriteLine();
        EndMessage();
    }
}