class CyclingActivity : Activity
{
    private decimal _speed;

    public CyclingActivity(string name, string date, decimal minutes, decimal speed) : base(name, date, minutes)
    {
        _speed = speed;
    }

    public override decimal GetSpeed()
    {
        return _speed;
    }
    public override decimal GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}