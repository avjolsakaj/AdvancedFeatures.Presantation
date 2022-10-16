using AdvancedFeaturesCoding.Shared.Implementations;

namespace AdvancedFeaturesCoding.ExerciseThree;

internal class Program
{
    private static void Main (string[] args)
    {
        var languages = new Dictionary<string, int>
        {
            { "C#", 10 },
            { "Java", 9 },
            { "Python", 8 },
            { "Web", 7 },
            { "T-Sql", 6 },
            { "JS", 5 }
        };

        Helpers.PrintDictionary(languages);
    }
}