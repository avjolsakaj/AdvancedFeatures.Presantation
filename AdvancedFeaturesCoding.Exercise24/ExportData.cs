namespace AdvancedFeaturesCoding.Exercise24;

public class CsvWriteRead
{
    public static string ExportCsv (List<string> list, string fileName, string path)
    {
        var finalPath = Path.Combine(path, fileName + ".csv");
        if (!File.Exists(finalPath))
        {
            var file = File.Create(finalPath);
            file.Close();
        }
        var result = list.Select(x => $"{x}");
        File.WriteAllLines(finalPath, result);
        return finalPath;
    }

    public static string ExportCsv (List<Cars> list, string fileName, string path)
    {
        var finalPath = Path.Combine(path, fileName + ".csv");
        if (!File.Exists(finalPath))
        {
            var file = File.Create(finalPath);
            file.Close();
        }
        var result = list.Select(x => $"{x.Name}, {x.Model}");

        File.WriteAllLines(finalPath, result);
        return finalPath;


    }

    public static string ReadCsv (string fileName)
    {
        return File.ReadAllText(fileName);
    }
}
