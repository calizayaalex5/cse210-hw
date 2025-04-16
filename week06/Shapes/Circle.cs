public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return 2 * 3.14 * (_radius * _radius);
    }
}