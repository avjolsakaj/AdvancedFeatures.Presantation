namespace AdvancedFeaturesCoding.Exercise12;

internal class Program
{
    private static void Main (string[] args)
    {
        var array1 = new int[] { 1, 4, 6, 4, 5, 5, 5 };

        var f = new Functionality();
        var list = f.DistinctItem(array1);
        foreach (var element in list)
        {
            Console.WriteLine(element);
        }
    }
}