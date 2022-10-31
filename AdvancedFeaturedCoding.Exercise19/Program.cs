namespace AdvancedFeaturedCoding.Exercise19;

internal class Program
{
    private static void Main (string[] args)
    {
        var basket = new Basket();

        var biskota = new Product
        {
            Name = "Biskota",
            Quantity = 3
        };

        var makarona = new Product
        {
            Name = "Makarona",
            Quantity = 2
        };

        var akullore = new Product
        {
            Name = "Akullore",
            Quantity = 1
        };

        var gjize = new Product
        {
            Name = "Gjize",
            Quantity = 5
        };

        var qumesht = new Product
        {
            Name = "Qumesht",
            Quantity = 2
        };

        var salce = new Product
        {
            Name = "Salce",
            Quantity = 2
        };

        var kallamar = new Product
        {
            Name = "Kallamar",
            Quantity = 2
        };

        var peshku = new Product
        {
            Name = "Peshku",
            Quantity = 2
        };

        var sheqer = new Product
        {
            Name = "Sheqer",
            Quantity = 2
        };

        var karamele = new Product
        {
            Name = "Karamele",
            Quantity = 2
        };

        var cola = new Product
        {
            Name = "Cola",
            Quantity = 2
        };

        basket.AddProduct(biskota);
        basket.AddProduct(makarona);
        basket.AddProduct(akullore);
        basket.AddProduct(qumesht);
        basket.AddProduct(gjize);
        basket.AddProduct(salce);
        basket.AddProduct(kallamar);
        basket.AddProduct(peshku);
        basket.AddProduct(sheqer);
        basket.AddProduct(peshku);
        //basket.AddProduct(cola);
        //basket.AddProduct(peshku);
        //basket.AddProduct(karamele);

        basket.RemoveProduct(biskota);
        basket.RemoveProduct(makarona);
        basket.RemoveProduct(akullore);
        basket.RemoveProduct(qumesht);
        basket.RemoveProduct(gjize);
        //basket.RemoveProduct(salce);
        //basket.RemoveProduct(kallamar);
        //basket.RemoveProduct(peshku);
        //basket.RemoveProduct(sheqer);
        //basket.RemoveProduct(peshku);
        //basket.RemoveProduct(peshku);

        foreach (var item in basket.GetProducts())
        {
            Console.WriteLine($"{item.Name}, {item.Quantity}");
        }
    }
}