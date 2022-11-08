namespace AdvancedFeaturesCoding.ExerciseTwentyOne;

internal class Program
{
    private static void Main (string[] args)
    {
        var numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10,11,12
        };

        //var newNumbers = new ExtendedList<int>(numbers);
        var newNumbers = new ExtendedListDefault<int>(numbers);

        var list = newNumbers.GetEveryNthElement(2, 3);

        foreach (var number in list)
        {
            Console.WriteLine(number);
        }
    }
}
