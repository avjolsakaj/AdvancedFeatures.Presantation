namespace AdvancedFeatues.PhotoAlbum;

internal class AlbumTest
{
    private static void Main (string[] args)
    {
        var album1 = new PhotoAlbum();
        Console.WriteLine($"{album1.GetName()}, has {album1.GetNumberOfPages()} pages!");

        var album2 = new PhotoAlbum(24, "Medium Album");
        Console.WriteLine($"{album2.GetName()}, has {album2.GetNumberOfPages()} pages!");

        var album3 = new BigPhotoAlbum("Big Album");
        Console.WriteLine($"{album3.GetName()}, has {album3.GetNumberOfPages()} pages!");
    }
}

public class PhotoAlbum
{
    private readonly int _nrPages;

    private readonly string _name;

    public PhotoAlbum (int nrPages, string name)
    {
        _nrPages = nrPages;
        _name = name;
    }

    public PhotoAlbum ()
    {
        _nrPages = 16;
        _name = "Small Album";
    }

    public int GetNumberOfPages () => _nrPages;

    public string GetName () => _name;
}

public class BigPhotoAlbum : PhotoAlbum
{
    public BigPhotoAlbum (string name) : base(64, name)
    {
    }
}