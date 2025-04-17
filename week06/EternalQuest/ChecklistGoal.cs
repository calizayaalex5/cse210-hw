public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for {_shortName}! ({_amountCompleted}/{_target})");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal and earned {_points + _bonus} points!");
        }
    } 

    public override bool IsCompleted()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsCompleted() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public int GetBonus()
    {
        return _bonus;
    }
}