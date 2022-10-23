namespace AdvancedFeaturesCoding.ExerciseSix;

internal class Program
{
    private static void Main (string[] args)
    {
        var parcel = new Parcel(500, 30, 30, 15, false);
        var validator = new Validator();

        if (validator.Validate(parcel))
        {
            Console.WriteLine("Validation has been made SUCCESSFULLY!");
        }
        else
        {
            Console.WriteLine("WARNING!");
        }
    }
}