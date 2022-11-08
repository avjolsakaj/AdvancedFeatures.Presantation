namespace AdvancedFeaturesCoding.ExerciseTwentyTwo;

internal class Program
{
    private static void Main (string[] args)
    {
        var path = @"C:\Users\DELL\Desktop\repository\file.txt";

        var content = File.ReadAllText(path!);
        var chars = content.ToCharArray();

        var newContent = string.Empty;
        for (var i = chars.Length - 1; i >= 0; i--)
        {
            newContent += chars[i];
        }

        Console.WriteLine(newContent);

        File.WriteAllText(path!, newContent);
    }
}