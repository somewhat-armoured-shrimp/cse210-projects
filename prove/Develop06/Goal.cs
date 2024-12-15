abstract class Goal
{
    private string _name;
    private string _description;
    // now a protected citizen
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // YOU ARE NOW RETURNING POINTS AS WELL
    public abstract int RecordEvent();
    public abstract bool IsAccomplished();
    // literally man i don't care i need name. if it's not 
    // inheritance-y enough then too bad o7
    public virtual string GetGoalName()
    {
        return _name;
    }
    public virtual string GetDetailString()
    {
        if (IsAccomplished())
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }
    // virtual now. does its job.
    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }
}