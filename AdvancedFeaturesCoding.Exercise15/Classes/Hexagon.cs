namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class Hexagon : Shape                               // 6 kendeshi
{

    public int X { get; set; }
    public override double CalculatePerimeter ()
    {
        return 6 * X;
    }
    public override double CalculateArea ()
    {
        return 3 * Math.Sqrt(3) / 2 * Math.Pow(X, 2);

    }
}
