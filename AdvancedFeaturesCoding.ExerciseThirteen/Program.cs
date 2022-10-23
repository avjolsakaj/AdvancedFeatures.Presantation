namespace AdvancedFeaturesCoding.ExerciseThirteen;

internal class Program
{
    private static void Main (string[] args)
    {
        var computer = new Computer
        {
            Ram = "12 gb",
            Processor = " i7",
            GPU = "nca",
            Company = "hp",
            Model = "1"
        };

        var laptop = new Laptop
        {
            Ram = "16 gb",
            Processor = " i3",
            GPU = "npis",
            Company = "dell",
            Model = "2",
            Battery = " 700"

        };

        Console.WriteLine("Computer Hash Code: " + computer.GetHashCode());
        Console.WriteLine("Computer Info: " + computer.ToString());
        Console.WriteLine("Computer is equal to laptop: " + computer.Equals(laptop));

        Console.WriteLine("Laptop Hash code:  " + laptop.GetHashCode());
        Console.WriteLine("Laptop Info: " + laptop.ToString());
        Console.WriteLine("Laptop is equal to laptop: " + laptop.Equals(laptop));
    }
}