namespace AdvancedFeaturedCoding.Exercise19;

public class BasketEmptyException : Exception
{
    public BasketEmptyException ()
    {
        Console.WriteLine("Basket is Empty");
    }
}
