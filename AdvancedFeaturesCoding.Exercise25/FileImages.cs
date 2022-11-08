using System.Text.RegularExpressions;


namespace AdvancedFeaturesCoding.Exercise25;

public class ImageFile
{
    public List<string> ImageList ()
    {
        var files = Directory.GetFiles("C:\\Users\\Hp\\Desktop\\photo", "*.*", SearchOption.AllDirectories);
        var imageFiles = new List<string>();
        foreach (var filename in files)
        {
            if (Regex.IsMatch(filename, @"\.jpg$|\.png$"))
            {
                imageFiles.Add(filename);
            }
        }
        return imageFiles;
    }

    public List<string> ImageList2 ()
    {
        var files = Directory.GetFiles("C:\\Users\\Hp\\Desktop\\photo", "*.png", SearchOption.AllDirectories)
            .Union(Directory.GetFiles("C:\\Users\\Hp\\Desktop\\photo", "*.jpg", SearchOption.AllDirectories))
            .ToList();

        return files;
    }
}
