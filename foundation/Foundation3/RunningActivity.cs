class RunningActivity : Activity
{
    // EVERYTHING is a decimal because who cares honestly i know doubles
    // are there or whatever but i can't be bothered
    private decimal _distance;
    // i just added a bunch of Math.Rounds but i dont have the mental
    // fortitude to change the

    public RunningActivity(string name, string date, decimal minutes, decimal distance) : base(name, date, minutes)
    {
        _distance = distance;
    }

    public override decimal GetDistance()
    {
        return _distance;
    }
    public override decimal GetSpeed()
    {
        return 60 / base.GetPace();
    }
    public override decimal GetPace()
    {
        return 60 / base.GetSpeed();
    }
}