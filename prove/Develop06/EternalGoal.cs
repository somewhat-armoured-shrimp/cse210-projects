class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        // won't mark completed, but still gives points.
        IsAccomplished();
        return _points;
    }
    public override bool IsAccomplished()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetStringRepresentation()}";
    }
}