using System;

public abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _description;
    private int _points;
    int _bonusPoints;
    int _numberOfTimes;
    int _recorded;
    public Goal()
    {
    }
    public Goal(string goalType, string goalName, string description, int points)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _points = points;
    }
    public Goal(string goalType, string goalName, string description, int points, int bonusPoints, int recorded, int numberOfTimes)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _numberOfTimes = numberOfTimes;
        _recorded = recorded;
    }
    public string GetGoalType()
    {
        return _goalType;
    }    
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        _goalName = goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription()
    {
        Console.Write("What is a short description of it? ");
        string goalDesciption = Console.ReadLine();
        _description = goalDesciption;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        _points = points;
    } 
    public void GetCommonInfo()
    {
        SetGoalName();
        SetDescription();
        SetPoints();
    }   
    public abstract string ToDisplayString();
    public abstract string ToSave();

    public virtual void SetRecordedValue(int record)
    {
        _recorded += record;
    }
    public virtual int GetRecordedValue()
    {
        return _recorded;
    }
    public virtual int GetTimesToAccomplishGoal()
    {
        return _numberOfTimes;
    }
    public virtual void SetTimesToAccomplishGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numberOfTimes = int.Parse(Console.ReadLine());
    }
    public virtual int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public virtual void SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
     public virtual void SetAsAccomplished()
    {
    }
}