using AdvancedFeaturesCoding.Shared;

namespace AdvancedFeaturesCoding.ExerciseOne;

public static class OrderDecending
{
    public static void Main ()
    {
        var listStrings = new List<string>
        {
            "Avjol",
            "Besian",
            "Lumturi",
            "Antonio",
            "Gezim"
        };

        var ordered = Helpers.OrderDescendingAlphabetically(listStrings);

        foreach (var item in ordered)
        {
            Console.WriteLine(item);
        }
    }
}