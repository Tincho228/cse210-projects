using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        Square sq = new Square("red",25);
        shapes.Add(sq);
        Rectangle re = new Rectangle("yellow", 2,3);
        shapes.Add(re);
        Circle ci = new Circle("greem", 6);
        shapes.Add(ci);
        
        foreach(Shape shape in shapes)
        {
            Display(shape);
        }
    }
    public static void Display(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"The color of the shape is {shape.Getcolor()}");
        Console.WriteLine($"The area is {area}");
    }
}