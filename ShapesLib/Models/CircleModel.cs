using ShapesLib.Interfaces;

namespace ShapesLib.Models;

public sealed class CircleModel: IShape
{
    private readonly double _radius;

    public CircleModel(double radius)
    {
        _radius = radius;
    }


    public double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}