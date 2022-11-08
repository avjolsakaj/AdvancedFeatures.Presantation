namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class GeneralTriangle : Shape //Trekendesh i cfaredoshem
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public int H { get; set; }

    public override double CalculatePerimeter ()
    {
        return X + Y + Z;
    }
    public override double CalculateArea ()
    {
        return X * H / 2;    // H eshte lartesia mbi brinjen x
    }
}
