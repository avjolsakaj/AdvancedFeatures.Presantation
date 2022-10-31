namespace AdvancedFeaturedCoding.Exercise19;

public class BasketFullException : Exception
{
    public BasketFullException ()
    {
        Console.WriteLine("Basket is Full");
    }
}
