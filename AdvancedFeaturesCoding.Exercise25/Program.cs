namespace AdvancedFeaturesCoding.Exercise25;

internal class Program
{
    private static void Main (string[] args)
    {
        //krijojm objekt te klases
        var file = new ImageFile();

        //afishojm elementet listes duke perdorur metoden e pare
        foreach (var item in file.ImageList())
        {
            Console.WriteLine("The image with " + item);
        }

        Console.WriteLine("\n");

        var file1 = new ImageFile();

        foreach (var item in file1.ImageList2())
        {
            Console.WriteLine("The image from 2 " + item);
        }

        //foreach (KeyValuePair<string, int> item in file1.ImageList())
        //{
        //    Console.WriteLine(item.Key, item.Value);
        //}
    }
}