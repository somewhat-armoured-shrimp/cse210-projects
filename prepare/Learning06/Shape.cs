public abstract class Shape
{
    private string _colour; // hah africk you ameriac >:)

    public Shape(string colour)
    {
        _colour = colour;
    }

    public string GetColour()
    {
        return _colour;
    }
    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public abstract double GetArea();


}