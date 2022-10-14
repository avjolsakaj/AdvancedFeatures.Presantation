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

        foreach (var item in OrderDecendingWithCase(listStrings))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Ignore Case");

        foreach (var item in OrderDecendingIgnoreCase(listStrings))
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> OrderDecendingWithCase (List<string> strings)
    {
        return strings.OrderByDescending(s => s).ToList();
    }

    public static List<string> OrderDecendingIgnoreCase (List<string> strings)
    {
        return strings.OrderByDescending(s => s, StringComparer.OrdinalIgnoreCase).ToList();
    }
}