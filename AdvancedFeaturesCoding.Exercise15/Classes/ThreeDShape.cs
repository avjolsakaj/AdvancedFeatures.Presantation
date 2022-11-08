using AdvancedFeaturesCoding.Exercise15.interfaces;

namespace AdvancedFeaturesCoding.Exercise15.Classes;

public abstract class ThreeDShape : Shape, IFillable
{

    public abstract double CalculateVolume (); // metoda abstrakte

    public int Fill (int quantity)   //metoda Fill
    {
        if (quantity == CalculateVolume())
            return 0;
        if (quantity > CalculateVolume())
            return 1;
        if (quantity < CalculateVolume())
            return -1;
        throw new OverflowException("Out of Range Exeption");
    }
}

