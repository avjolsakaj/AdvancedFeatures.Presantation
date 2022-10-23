namespace AdvancedFeaturesCoding.ExerciseSix;

public class Parcel
{
    private readonly int xLength;
    private readonly int yLength;
    private readonly int zLength;
    private readonly float weight;
    private readonly bool isExpress;

    public Parcel (int xLength, int yLength, int zLength, float weight, bool isExpress)
    {
        this.xLength = xLength;
        this.yLength = yLength;
        this.zLength = zLength;
        this.weight = weight;
        this.isExpress = isExpress;
    }

    public bool ValidateSum ()
    {
        return xLength + yLength + zLength < 300;
    }

    public bool ValidateEachDimensionSize ()
    {
        return xLength > 30 || yLength > 30 || zLength > 30;
    }

    public bool ValidateWeight ()
    {
        return (isExpress == false && weight <= 30) || (isExpress == true && weight <= 15);
    }
}

