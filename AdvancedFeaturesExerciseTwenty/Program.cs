using AdvancedFeaturesCoding.ExerciseTwenty;

namespace AdvancedFeaturesExerciseTwenty
{
    internal class Program
    {
        private static void Main (string[] args)
        {
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7
            };

            var strings = new List<string>
            {
                "koli",
                "enio",
                "aleks"
            };

            var joining = new Joiner<int>(",");
            var result = joining.Join(numbers);

            var joiningString = new Joiner<string>(",");
            var resultString = joiningString.Join(strings);

            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(resultString);
        }
    }
}