class Square : Shape
{
    private double _side;

    public Square(string colour, double side) : base(colour)
    {
        // when derived constructors have their funny parameters
        // specific to them, uhhhh remember to define them
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

}