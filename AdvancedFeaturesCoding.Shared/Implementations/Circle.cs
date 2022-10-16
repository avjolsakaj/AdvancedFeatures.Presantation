using AdvancedFeaturesCoding.Shared.Interfaces;

namespace AdvancedFeaturesCoding.Shared.Implementations;

public class Circle : IMovable, IResizable
{
    private readonly Point2D _center;
    private readonly Point2D _point;

    public Circle (Point2D center, Point2D point)
    {
        _center = center;
        _point = point;
    }

    public double GetRadius ()
    {
        // Get circle's radius
        var poweredX = Math.Pow(_point.X - _center.X, 2);
        var poweredY = Math.Pow(_point.Y - _center.Y, 2);

        var radius = Math.Sqrt(poweredX + poweredY);

        return radius;
    }

    public double GetDiameter ()
    {
        // Get circle's diameter
        return 2 * GetRadius();
    }

    public double GetPerimeter ()
    {
        // Get circle's perimeter
        return Math.PI * GetDiameter();

        //return 2 * Math.PI * GetRadius();
    }

    public double GetArea ()
    {
        // Get circle's area
        return Math.PI * Math.Pow(GetRadius(), 2);
        //return (Math.PI * Math.Pow(GetDiameter(), 2)) / 4;
    }

    public List<Point2D> GetSlicePoints ()
    {
        var result = new List<Point2D>();

        for (var i = 0; i < 3; i++)
        {
            result.Add(GetPoint2DAfterRotationWithDegree(90 + (i * 90)));
        }

        // Return list of points for 3 rotations with 90 degrees
        return result;
    }

    private Point2D GetPoint2DAfterRotationWithDegree (double degree)
    {
        // Radion is calculated from degree
        var radian = degree * Math.PI / 180;

        var x = (_point.X * Math.Cos(radian)) - (_point.Y * Math.Sin(radian));
        var y = (_point.X * Math.Sin(radian)) + (_point.Y * Math.Cos(radian));

        return new Point2D(Math.Round(x, 2), Math.Round(y, 2));
    }

    public void Move (MoveDirection moveDirection)
    {
        // Move center
        _center.Move(moveDirection);

        // Move point
        _point.Move(moveDirection);
    }

    public void Resize (double resizeFactor)
    {
        var x = _point.X - _center.X;
        var y = _point.Y - _center.Y;

        var tngDegree = x / y;
        var hipotenuz = resizeFactor * GetRadius();

        _point.X = hipotenuz * tngDegree;
        _point.Y = hipotenuz / tngDegree;
    }
}

