using System.Reflection.Metadata.Ecma335;

public abstract class Shape {
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string Getcolor()
    {
        return _color;
    }

    public abstract double GetArea();
    
}