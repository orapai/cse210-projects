using System;

public class SimpleGoal : Goal
{
    private Boolean _accomplished = false;
    public SimpleGoal()
    {
    }
    public SimpleGoal(string goalType, string goalName, string description, int points, Boolean accomplished) : base(goalType, goalName, description, points)
    {
        _accomplished = accomplished;
    }
    public override void SetAsAccomplished()
    {
        _accomplished = true;
    }
    public override string ToDisplayString()
    {
        return string.Format("[{0}] {1} ({2})",((_accomplished == false)? " " : "X"), GetGoalName(), GetDescription());
    }
    public override string ToSave()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}",GetGoalType(), GetGoalName(), GetDescription(), GetPoints(), _accomplished);
    }
}