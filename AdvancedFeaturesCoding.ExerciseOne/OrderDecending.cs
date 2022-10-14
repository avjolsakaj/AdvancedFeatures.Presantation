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

        foreach (var item in Helpers.OrderDecendingAlphabetically(listStrings))
        {
            Console.WriteLine(item);
        }
    }
}