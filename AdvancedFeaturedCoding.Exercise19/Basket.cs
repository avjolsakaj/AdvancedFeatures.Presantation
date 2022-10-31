namespace AdvancedFeaturedCoding.Exercise19;

public class Basket
{
    private List<Product> products;

    public Basket ()
    {
        products = new List<Product>();
    }


    public void AddProduct (Product product)
    {
        var prod = products.FirstOrDefault(p => p.Name == product.Name);

        if (prod == null)
        {
            if (IsFull())
            {
                throw new BasketFullException();
            }

            products.Add(product);
        }
        else
        {
            prod.Quantity += product.Quantity;
        }
    }

    public List<Product> GetProducts ()
    {
        return products;
    }

    public void RemoveProduct (Product product)
    {
        if (IsEmpty())
        {
            throw new BasketEmptyException();
        }

        var prod = products.FirstOrDefault(p => p.Name == product.Name);

        if (prod == null)
        {
            return;
        }

        products.Remove(prod);
    }

    public bool IsEmpty ()
    {
        return products.Count == 0;
    }

    public bool IsFull ()
    {
        return products.Count == 10;
    }
}
