public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal (string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"Event recorded for goal: {_shortName}");
    }

    public virtual bool IsCompleted()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points.ToString()}";
    }
}