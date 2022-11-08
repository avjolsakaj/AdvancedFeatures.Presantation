using System.Text;
namespace AdvancedFeaturesCoding.Exercise23;

public class FileExport
{
    public static void SaveToFile (Dictionary<string, int> stats)
    {
        var csv = new StringBuilder();
        foreach (var item in stats)
        {
            //Suggestion made by KyleMit
            var newLine = string.Format("{0}, {1}", item.Key, item.Value);
            _ = csv.AppendLine(newLine);
        }

        // Print word count Results
        File.WriteAllText(@"c:\MilkyWay.txt", csv.ToString());
    }
}