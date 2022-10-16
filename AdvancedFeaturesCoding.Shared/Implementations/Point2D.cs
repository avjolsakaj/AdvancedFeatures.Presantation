using AdvancedFeaturesCoding.Shared.Interfaces;

namespace AdvancedFeaturesCoding.Shared.Implementations;

public class Point2D : IMovable
{
    //private double _x;
    //public double X { get => _x; set => _x = value; }

    public double X { get; set; }
    public double Y { get; set; }

    public Point2D (double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Move (MoveDirection moveDirection)
    {
        X += moveDirection.X;
        Y += moveDirection.Y;
    }

    public override string ToString ()
    {
        return $"X: {X}, Y: {Y}";
    }
}
