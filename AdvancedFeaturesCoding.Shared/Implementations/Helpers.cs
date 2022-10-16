namespace AdvancedFeaturesCoding.Shared.Implementations;

public class Helpers
{
    public static void PrintDictionary (Dictionary<string, int> languages)
    {
        for (var i = 0; i < languages.Count; i++)
        {
            var pair = languages.ElementAt(i);

            //var stringValue = $"Key: {pair.Key}, Value: {pair.Value}";
            //stringValue = (i == languages.Count - 1) ? $"{stringValue}." : $"{stringValue},";
            //Console.WriteLine(stringValue);

            if (i < languages.Count - 1)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value},");
            }
            else
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}.");
            }
        }
    }

    public static List<string> OrderDescendingAlphabetically (List<string> strings)
    {
        return strings.OrderByDescending(s => s).ToList();
    }

    public static List<string> OrderDescendingWithCase (List<string> strings)
    {
        return strings.OrderByDescending(s => s).ToList();
    }

    public static List<string> OrderDescendingIgnoreCase (List<string> strings)
    {
        return strings.OrderByDescending(s => s, StringComparer.OrdinalIgnoreCase).ToList();
    }
}