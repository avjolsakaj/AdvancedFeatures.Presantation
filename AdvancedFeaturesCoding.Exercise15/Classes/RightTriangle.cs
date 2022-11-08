namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class RightTriangle : Shape                         // Trekendeshi Kendedrejt
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public override double CalculatePerimeter ()
    {
        return X + Y + Z;
    }
    public override double CalculateArea ()
    {
        return X * Y / 2;

    }
}
