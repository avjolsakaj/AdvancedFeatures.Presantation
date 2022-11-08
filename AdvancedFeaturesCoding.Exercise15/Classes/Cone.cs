namespace AdvancedFeaturesCoding.Exercise15.Classes;

public class Cone : ThreeDShape
{
    public int R { set; get; }
    public int H { set; get; }

    public override double CalculateArea ()
    { return R * H / 2; }


    public override double CalculatePerimeter ()
    {
        return Math.PI * R * 2;
    }

    public override double CalculateVolume ()
    {

        return Math.PI * Math.Pow(R, 2) * H / 3; // na duhet H, lartesia mbi bazen e konit, e cila e bie ne qender te rrethit

    }
}
