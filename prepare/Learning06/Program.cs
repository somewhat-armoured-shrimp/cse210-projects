using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // stealing name thing because you gotta get reminded
        // that all these guys are SHAPES and personal identity is
        // a LIE 
        Square shape1 = new Square("BLue :)", 4);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Orange", 3, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 69);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {   
            string colour = shape.GetColour();

            // each guy has a same method thing but they all do 
            // different stuff but you don't gotta specify? based??
            double area = shape.GetArea();

            Console.WriteLine($"Le {colour} shape has an area of {area}. Disgusting!");


        }
    }
}