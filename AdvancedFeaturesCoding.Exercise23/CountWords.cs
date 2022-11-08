namespace AdvancedFeaturesCoding.Exercise23;

public class CountWords
{
    public static Dictionary<string, int> Count (string text)
    {
        var source = text.Split(new char[] { '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var stats = new Dictionary<string, int>();

        foreach (var w in source)
        {

            if (!stats.ContainsKey(w))
            {
                stats.Add(w, 1); // add new word to collection
            }
            else
            {
                stats[w] += 1; // update word occurrence count
            }
        }

        return stats;
    }
}