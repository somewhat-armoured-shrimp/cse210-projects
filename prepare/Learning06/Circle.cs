class Circle : Shape
{
    private double _radius;

    public Circle(string colour, double radius) : base(colour)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * Math.Pow(_radius, 2); // man who care dud
    }
}   