class SwimmingActivity : Activity
{
    private decimal _laps;

    public SwimmingActivity(string name, string date, decimal minutes, decimal laps) : base(name, date, minutes)
    {
        _laps = laps;
    }

    public override decimal GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62m, 2);
    }
    public override decimal GetSpeed()
    {
        return 60 / base.GetPace();
    }
    public override decimal GetPace()
    {
        return Math.Round(60 / base.GetPace(), 2);
    }
    
}