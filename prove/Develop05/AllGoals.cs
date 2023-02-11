using System;
using System.IO;
using System.Diagnostics;

public class AllGoals
{
    private int _voidCounter = 0;
    private List<Goal> _allGoal = new List<Goal>();
    private int _points = 0;

    public void Add(Goal goal)
    {
        _allGoal.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _points;
    }
    public void SetTotalPoints(int points)
    {
        _points += points;
    }
    public string GetFileName()
    {
        Console.WriteLine("What is the filename? ");
        return Console.ReadLine();
    }
    public void displayList()
    {
        Console.WriteLine("The goals are: ");
        if (_allGoal.Count == 0)
        {
            Console.WriteLine("No goals have been added or loaded yet. ");
        }
        int x = 0;
        foreach (Goal goal in _allGoal)
        {
            Console.WriteLine($"{x+1}. {goal.ToDisplayString()}");
            x++;
        }
        Pause(3);
    }
    public List<string> SaveGoals()
    {
        int x = 0;
        List<string> goals = new List<string>();
        goals.Add(GetTotalPoints().ToString());
        foreach (Goal goal in _allGoal)
        {
            string goalAdded = goal.ToSave();
            goals.Add(goalAdded);
            x++;
        }
        Console.WriteLine("Goals saved.");
        Pause(3);
        return goals;
    }
    public List<string> LoadFile(string filenameRead)
    {
        List<string> fromFile = new List<string>();
        StreamReader streamReader = new StreamReader(filenameRead);
        
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromFile.Add(line.ToString());
        }
        streamReader.Close();

        return fromFile;
    }
    public void LoadGoals()
    {
        List<string> loadedFile = LoadFile(GetFileName());
        Goal goal = null;
        foreach(string goalFromFile in loadedFile)
        {
            string[] goalParts = goalFromFile.Split('|');
            string goalType = goalParts[0];
            switch(goalType)
            {
                case "Simple Goal":
                _points = int.Parse(goalParts[3]);
                SetTotalPoints(_points);
                goal = new SimpleGoal(goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
                break;
                case "Eternal Goal":
                _points = int.Parse(goalParts[3]);
                SetTotalPoints(_points);
                goal = new EternalGoal(goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]));
                break;
                case "Checklist Goal":
                _points = int.Parse(goalParts[3]);
                SetTotalPoints(_points);
                goal = new ChecklistGoal(goalParts[0], goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]));
                break;
            }
            if(goal != null && _allGoal.Contains(goal) == false)
            {
                _allGoal.Add(goal);
            }

        }
        Console.WriteLine("Goals loaded.");
        Pause(2);
        Console.Clear();
    }
    public void displayGoalsToAccomplish()
    {
        Console.WriteLine("The goals are: ");
        if (_allGoal.Count == 0)
        {
            Console.WriteLine("No goals have been added or loaded yet. ");
        }
        int x = 0;
        foreach (Goal goal in _allGoal)
        {
            Console.WriteLine($"{x+1}. {goal.GetDescription()}");
            x++;
        }
        Console.WriteLine();
        Pause(2);
    }
    public void RecordGoalAccomplished()
    {
        displayGoalsToAccomplish();
        Console.Write("What did you accomplish? ");
        int accomplished = int.Parse(Console.ReadLine());
        int x = 0;
        foreach (Goal goal in _allGoal)
        {
            if( x+1 == accomplished)
            {
                SetTotalPoints(goal.GetPoints());
                string goalType = goal.GetGoalType();
                switch (goalType)
                {
                    case "Simple Goal":
                    goal.SetAsAccomplished();
                    break;
                    case "Eternal Goal":
                    break;
                    case "Checklist Goal":
                    goal.SetRecordedValue(1);
                    if (goal.GetTimesToAccomplishGoal() ==  goal.GetRecordedValue())
                    {
                        SetTotalPoints(goal.GetBonusPoints());
                    }
                    break;
                }
                Console.WriteLine($"Congratulations! You have earned {GetTotalPoints()} points!");
                Pause(3);
            }
            x++;
        }

    }
    public void Pause(int duration)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < duration)
        {
            _voidCounter ++;
            switch(_voidCounter % 4)
            {
                case 0: Console.Write(" "); break;
                case 1: Console.Write(" "); break;
                case 2: Console.Write(" "); break;
                case 3: Console.Write(" "); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(250);
        }
        Console.Write(" ");
    }
}