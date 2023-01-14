using System;

public class Prompt
{
    private List<string> _promptList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new that I've learned today?",
        "What unexpected things did happen today?",
        "To whom were you able to serve this day?"
    };

    public string GetPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(_promptList.Count);
        string prompt = _promptList[number];
        return prompt;
    }
}