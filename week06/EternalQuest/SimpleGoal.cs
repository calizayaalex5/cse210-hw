public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You completed the goal: {_shortName} and earned {_points} points!");
    }

    public override bool IsCompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string status = _isComplete ? "[x]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }
}