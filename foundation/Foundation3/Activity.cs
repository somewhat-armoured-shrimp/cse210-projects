class Activity
{
    private string _name; // idk for constructor reasons because no overriding
    // also who cares it's not doing anything wrong hes just /there/
    private string _date;
    private decimal _minutes; 

    public Activity(string name, string date, decimal minutes)
    {
        _name = name;
        _date = date;
        _minutes = Math.Round(minutes, 2);
    }

    public virtual decimal GetDistance()
    {
        return GetSpeed() * _minutes;
    }
    public virtual decimal GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }
    public virtual decimal GetPace()
    {
        return _minutes / GetDistance();
    }
    public string GetSummary()
    {
        return $"{_date} {_name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}