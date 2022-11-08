namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class Qube : ThreeDShape
{
    public int X { set; get; }
    public Qube (int x)  // inicializimi me kontruktor
    {
        X = x;
    }


    public override double CalculateArea ()
    {
        return 6 * Math.Pow(X, 2);
    }
    public override double CalculatePerimeter ()
    {
        return Math.PI * X * 2;
    }
    public override double CalculateVolume ()
    {
        return Math.Pow(X, 3);
    }
}
