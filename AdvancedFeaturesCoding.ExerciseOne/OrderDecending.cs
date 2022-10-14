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

        foreach (var item in OrderDecendingAlphabetically(listStrings))
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> OrderDecendingAlphabetically (List<string> strings)
    {
        return strings.OrderByDescending(s => s).ToList();
    }
}