class ChecklistGoal : Goal
{
    private int _targetAmount; // literally forgot. who are you (nvm it was the target amount, targetTime was not a great name :(  )
    private int _amountAccomplished;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus) : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        // amount accomplished go up one 
        _amountAccomplished++;

        // self explanatory
        if (_amountAccomplished < _targetAmount)
        {
            return _points;
        }
        else if (_amountAccomplished == _targetAmount)
        {
            return _bonus;
        }
        return 0;
    }
    public override bool IsAccomplished()
    {
        return _amountAccomplished == _targetAmount;
    }
    public override string GetDetailString()
    {
        // YOU CAN CALL THE BASE METHOD TO GET ITS FORMAT BABE
        return $"{base.GetDetailString()} -- Times Completed: {_amountAccomplished}/{_targetAmount}";
    }
    // same trick now.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetStringRepresentation()},{_amountAccomplished},{_targetAmount}";
    }
}