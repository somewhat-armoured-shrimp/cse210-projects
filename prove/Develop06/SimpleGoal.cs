class SimpleGoal : Goal
{
    private bool _isAccomplished;

    public SimpleGoal(string name, string description, int points, bool IsAccomplished) : base(name, description, points)
    {
        _isAccomplished = IsAccomplished;
    }

    public override int RecordEvent()
    {
        // assumes and returns. or something
        _isAccomplished = true;
        return _points;
    }
    public override bool IsAccomplished()
    {
        return _isAccomplished; // :)
    }
    public override string GetStringRepresentation()
    {
        // file-friendly(?) string
        // SimpleGoal:Name,Description,Points or something like that
        return $"SimpleGoal:{base.GetStringRepresentation()},{IsAccomplished()}";
    }
}