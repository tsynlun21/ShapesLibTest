using ShapesLib.Interfaces;

namespace ShapesLib.Models;

public sealed class TriangleModel : IShape
{
    private readonly double _sideA, _sideB, _sideC;
    private const double EPSYLON = 1e-5;

    public TriangleModel(double a, double b, double c)
    {
        _sideA = a;
        _sideB = b;
        _sideC = c;
    }

    public double GetPerimeter()
    {
        return _sideA + _sideB + _sideC;
    }
    public double GetArea()
    {
        var semiArea = GetPerimeter() / 2;

        return Math.Sqrt(semiArea * (
            (semiArea - _sideA) *
            (semiArea - _sideB) *
            (semiArea - _sideC)));
    }

    public bool IsRight()
    {
        var aSquared = _sideA * _sideA;
        var bSquared = _sideB * _sideB;
        var cSquared = _sideC * _sideC;

        return (Math.Abs(aSquared + bSquared - cSquared) < EPSYLON) ||
               (Math.Abs(aSquared + cSquared - bSquared) < EPSYLON) ||
               (Math.Abs(bSquared + cSquared - aSquared) < EPSYLON);
    }

    
}