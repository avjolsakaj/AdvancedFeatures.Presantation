namespace AdvancedFeaturesCoding.ExerciseSix;

public class Validator : IValidator
{
    public bool Validate (Parcel parcel)
    {
        return parcel.ValidateSum() && parcel.ValidateEachDimensionSize() && parcel.ValidateWeight();
    }
}

