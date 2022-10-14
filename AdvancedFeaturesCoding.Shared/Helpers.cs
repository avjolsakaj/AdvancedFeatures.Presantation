namespace AdvancedFeaturesCoding.Shared;

public class Helpers
{
    public static void PrintDictionary (Dictionary<string, int> languages)
    {
        for (var i = 0; i < languages.Count; i++)
        {
            var pair = languages.ElementAt(i);

            var stringValue = $"Key: {pair.Key}, Value: {pair.Value}";

            stringValue = (i == languages.Count - 1) ? $"{stringValue}." : $"{stringValue},";

            Console.WriteLine(stringValue);
        }
    }

    public static List<string> OrderDecendingAlphabetically (List<string> strings)
    {
        return strings.OrderByDescending(s => s).ToList();
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