using System.ComponentModel;

public class EternalGoal : Goal
{
        public EternalGoal (string name, string description, int points) : base(name, description, points)
    {    
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded progress on the eternal goal: {_shortName} and earned {_points} points!");
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}