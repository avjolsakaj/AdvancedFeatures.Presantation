namespace AdvancedFeaturesCoding.Exercise18;

internal class Program
{
    private static void Main (string[] args)
    {
        var z = new Dictionary<string, int>
        {
            { "Lion", 3 },
            { "Mamouth", 4 },
            { "Tiger", 7 },
            { "Dinosaour", 1 },
            { "Bear", 2 }
        };

        var a = new Zoo(z);

        var sum = a.GetNumberOfAllAnimals();
        Console.WriteLine("Total number of animals in the zoo is " + sum);
        Console.WriteLine();
        foreach (var pair in a.GetAnimalsCount())
        {
            Console.WriteLine("Zoo has {0} {1} ", pair.Value, pair.Key);
        }

        Console.WriteLine();
        Console.WriteLine("The number of elements sorted:");

        foreach (var item in a.GetAnimalsCountSorted())
        {
            Console.WriteLine("{0}, {1}", item.Key, item.Value);
        }

        Console.WriteLine();
        a.AddAnimals("Elefant", 2);
        a.AddAnimals("Dinosaour", 2);
        foreach (var pair in a.GetAnimalsCount())
        {
            Console.WriteLine("Zoo has {0} {1} ", pair.Value, pair.Key);
        }
    }
}