using System;

public class EternalGoal : Goal
{
    public EternalGoal()
    {
    }
    public EternalGoal(string goalType, string goalName, string description, int points) : base(goalType, goalName, description, points)
    {
    }
    public override string ToDisplayString()
    {
        return string.Format("[{0}] {1} ({2})"," ", GetGoalName(), GetDescription());
    }
    public override string ToSave()
    {
        return string.Format("{0}|{1}|{2}|{3}",GetGoalType(), GetGoalName(), GetDescription(), GetPoints());
    }
} 