using System;

public class ChecklistGoal : Goal
{
    int _bonusPoints;
    int _numberOfTimes;
    int _recorded;
    public ChecklistGoal()
    {
    }
    public ChecklistGoal(string goalType, string goalName, string description, int points, int bonusPoints, int recorded, int numberOfTimes): base(goalType, goalName, description, points, bonusPoints,  recorded, numberOfTimes)
    {
        _bonusPoints = bonusPoints;
        _numberOfTimes = numberOfTimes;
        _recorded = recorded;
    }
    public override void SetRecordedValue(int record)
    {
        _recorded += record;
    }
    public override int GetRecordedValue()
    {
        return _recorded;
    }
    public override int GetTimesToAccomplishGoal()
    {
        return _numberOfTimes;
    }
    public override void SetTimesToAccomplishGoal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numberOfTimes = int.Parse(Console.ReadLine());
    }
    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override void SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override string ToDisplayString()
    {
        return string.Format("[{0}] {1} ({2}) -- currently completed {3}/{4}",((_recorded == _numberOfTimes)? "x": " "), GetGoalName(), GetDescription(), GetRecordedValue(), GetTimesToAccomplishGoal());
    }
    public override string ToSave()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",GetGoalType(), GetGoalName(), GetDescription(), GetPoints(), _bonusPoints, _recorded, _numberOfTimes);
    }
    
}