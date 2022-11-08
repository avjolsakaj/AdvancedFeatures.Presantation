namespace AdvancedFeaturesCoding.Exercise23;

internal class Program
{
    private static void Main (string[] args)
    {
        var text = @"Write a program that will solve the problem below. There is a system
                that stores current results in competitions. Many screens read the
                current results, while several sensors update these results. Write a
                program that allows continuous reading of data through many screens
                (threads) and updating data by many sensors (threads). To update
                results, the sensor must provide current results along with new ones. The
                system then verifies that the sensor has current data and updates the
                data. If the system data has changed during this time, the sensor's data
                update is rejected. For simplicity, you can assume that the sensor is
                reading data, waiting a random amount of time, and increasing the
                data by a random value.";

        var stats = CountWords.Count(text);

        // order the collection by word count
        var orderedStats = stats.OrderByDescending(x => x.Value);

        foreach (var pair in orderedStats)
        {
            Console.WriteLine("Total occurrences of {0}: {1}", pair.Key, pair.Value);
        }

        Console.WriteLine("Total unique word count: {0}", stats.Count);

        FileExport.SaveToFile(stats);
    }
}