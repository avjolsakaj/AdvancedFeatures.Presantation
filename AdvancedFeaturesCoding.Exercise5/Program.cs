namespace AdvancedFeaturesCoding.Exercise5;

public class Program
{
    private static void Main (string[] args)
    {
        var pistoletMagazine = new Magazine(12);
        pistoletMagazine.LoadBullet(5);
        Console.Write(pistoletMagazine.IsLoaded());

        for (var i = 0; i < 7; i++)
        {
            if (pistoletMagazine.IsLoaded() == false)
            {
                Console.WriteLine("Empty Magazine");
            }
            else
            {
                Console.WriteLine("Shoot");
                pistoletMagazine.Shot();
            }
        }
    }
}

public class Magazine
{
    private readonly int _max;
    private int NumberOfBullet;

    public Magazine (int max)
    {
        _max = max;
        NumberOfBullet = 0;
    }

    public void LoadBullet (int bullet)
    {
        NumberOfBullet = bullet > _max ? _max : bullet;
    }

    public bool IsLoaded ()
    {
        return NumberOfBullet > 0;
    }

    public void Shot ()
    {
        NumberOfBullet--;
    }
}