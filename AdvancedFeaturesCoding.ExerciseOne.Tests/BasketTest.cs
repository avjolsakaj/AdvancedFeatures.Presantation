using AdvancedFeaturedCoding.Exercise19;

namespace Test
{
    public class BasketTest
    {
        private Basket _basket;
        private Product _biskota;

        [SetUp]
        public void SetUp ()
        {
            _basket = new Basket();
            _biskota = new Product
            {
                Name = "Biskota",
                Quantity = 2
            };
            _basket.AddProduct(_biskota);
        }


        [TearDown]
        public void TearDown ()
        {
            _basket = null;
        }

        [Test]
        public void BasketNotEmptyTest ()
        {
            Assert.That(_basket.IsEmpty, Is.Not.True);
        }

        [Test]
        public void BasketIsFullTest ()
        {
            Assert.That(_basket.IsFull, Is.Not.True);
        }

        [Test]
        public void GetProductTest ()
        {
            Assert.That(_basket.GetProducts().Any(x => x.Name == _biskota.Name), Is.True);
        }

        [Test]
        public void BasketAddProductTest ()
        {
            _basket.AddProduct(new Product
            {
                Name = "Makarona",
                Quantity = 2

            });

            Assert.That(_basket.GetProducts().Any(x => x.Name == "Makarona"), Is.True);
        }

        [Test]
        public void BasketRemoveTest ()
        {
            _basket.RemoveProduct(_biskota);
            Assert.That(_basket.GetProducts().Count, Is.EqualTo(0));
        }
    }
}
