using AdvancedFeaturesCoding.Shared;

namespace AdvancedFeaturesCoding.ExerciseTwo;

public class Program
{
    public static void Main ()
    {
        var listStrings = new List<string>
        {
            "aPPLE", "APPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "clover", "CLOVER", "cHeRry"
        };

        Console.WriteLine("With Case sensitive");

        foreach (var item in Helpers.OrderDescendingWithCase(listStrings))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("===========================");

        Console.WriteLine("Ignore Case");

        foreach (var item in Helpers.OrderDescendingIgnoreCase(listStrings))
        {
            Console.WriteLine(item);
        }
    }
}