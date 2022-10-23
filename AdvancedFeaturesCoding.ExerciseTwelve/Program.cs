namespace AdvancedFeaturesCoding.ExerciseTwelve;

internal class Program
{
    private static void Main (string[] args)
    {
        var input = new int[100];
        var random = new Random();

        for (var i = 0; i < input.Length; i++)
        {
            input[i] = random.Next(input.Length);
        }

        Console.WriteLine($"Numbers: {string.Join(",", input)}");

        Console.WriteLine("==========================================");
        var uniqueNumbers = Shared.UniqueList(input);
        Console.WriteLine($"Unique Numbers: {string.Join(",", uniqueNumbers)}");

        Console.WriteLine("==========================================");
        var atLeastOnceNumbers = Shared.AtLeastOnce(input);
        Console.WriteLine($"At least once: {string.Join(",", atLeastOnceNumbers)}");

        Console.WriteLine("==========================================");
        var mostFrequent = Shared.MostFrequent(input, 25);
        Console.WriteLine($"Most frequently used: {string.Join(",", mostFrequent)}");

        Console.WriteLine("==========================================");
        var allUnique = Shared.AllUnique(input);
        Console.WriteLine($"All unique: {string.Join(",", allUnique)}");
    }
}

public static class Shared
{
    private static Dictionary<int, int> ToDictionary (int[] input)
    {
        var result = new Dictionary<int, int>();
        foreach (var i in input)
        {
            if (!result.ContainsKey(i))
            {
                result.Add(i, 1);
            }
            else
            {
                result[i]++;
            }
        }
        return result;
    }

    public static List<int> UniqueList (int[] input)
    {
        var result = ToDictionary(input);
        return result.Where(k => k.Value == 1).Select(k => k.Key).ToList();
    }

    public static List<int> AtLeastOnce (int[] input)
    {
        var result = ToDictionary(input);
        return result.Where(k => k.Value > 1).Select(k => k.Key).ToList();
    }

    public static List<int> MostFrequent (int[] input, int take)
    {
        var result = ToDictionary(input);
        return result.OrderByDescending(x => x.Value)
            .Take(take)
            .Select(k => k.Key)
            .ToList();
    }

    public static List<int> DeDublicated (int[] input)
    {
        var random = new Random();
        var result = ToDictionary(input);
        var list = result.Where(k => k.Value == 1).Select(k => k.Key).ToList();
        for (var i = 0; i < list.Count - 1; i++)
        {
            if (list.Contains(list[i]))
            {
                var newnumber = random.Next(100000);
                while (!list.Contains(newnumber))
                {
                    newnumber = random.Next(100000);
                }
                list.RemoveAt(i);
                list[i] = random.Next(10000);
            }
        }
        return list;
    }

    public static List<int> AllUnique (int[] input)
    {
        var unique = UniqueList(input);
        var rand = new Random();

        while (unique.Count <= input.Length)
        {
            int number;

            do
            {
                number = rand.Next(unique.Max(), input.Length * 100);
            } while (unique.Contains(number));

            unique.Add(number);
        }

        return unique;
    }
}
