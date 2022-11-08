namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class Rectangle : Shape                       //Drejtkendeshi
{

    private int X;
    private int Y;

    public Rectangle (int x, int y)  // inicializimi me kontruktor
    {
        X = x;
        Y = y;
    }
    public override double CalculatePerimeter ()
    {
        return 2 * (X + Y);
    }
    public override double CalculateArea ()
    {
        return X * Y;
    }
}
