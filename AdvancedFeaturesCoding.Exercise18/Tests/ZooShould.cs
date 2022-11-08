using NUnit.Framework;

namespace AdvancedFeaturesCoding.Exercise18.Tests
{
    public class ZooShould
    {
        private Dictionary<string, int> _animals = new();

        private Zoo? zoo;

        [SetUp]
        public void Setup ()
        {
            _animals = new Dictionary<string, int>
            {
                { "Dog", 2 },
                { "Cat", 1 }
            };

            zoo = new Zoo(_animals);
        }

        [TearDown]
        public void TearDown ()
        {
            _animals.Clear();
            zoo = null;
        }

        [Test]
        public void GetNumberOfAllAnimals ()
        {
            var result = zoo.GetNumberOfAllAnimals();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void GetAnimalsCount ()
        {
            var result = zoo.GetAnimalsCount();
            Assert.AreEqual(result, _animals);
        }

        [Test]
        public void AddAnimals ()
        {
            zoo.AddAnimals("Dog", 1);
            Assert.AreEqual(3, _animals["Dog"]);

        }

        [Test]
        public void GetAnimalsCountSorted ()
        {
            var sorted = zoo.GetAnimalsCountSorted();
            Assert.AreEqual(sorted.ElementAt(0).Key, "Dog");
            Assert.AreEqual(sorted.ElementAt(0).Value, 2);
        }
    }
}