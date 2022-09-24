namespace AdvancedFeatures.EditFile;
internal class Program
{
    private static void Main ()
    {
        ReadAllTextFromPath();
    }

    /// <summary>
    /// Get full path, reads its contents and prints it on the console
    /// </summary>
    private static void ReadAllTextFromPath ()
    {
        Console.WriteLine("Please enter a file path");

        var path = Console.ReadLine();

        try
        {
            Console.WriteLine("Before change:");

            var content = File.ReadAllText(path!);
            Console.WriteLine(content);

            // Check this link for more https://stackoverflow.com/a/19691606/9294131
            File.AppendAllLines(path!, new[] { "My First Extra Content." });

            Console.WriteLine("After change:");

            content = File.ReadAllText(path!);
            Console.WriteLine(content);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path was not provided! We need the path.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path is too long! Path should be shorter.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory was not found! Put a valid directory.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found! Put a valid path to file.");
        }

        _ = Console.ReadKey();
    }
}