using NUnit.Framework;

namespace AdvancedFeaturesCoding.Exercise24.Tests
{
    public class Exercise24Test
    {
        private List<Cars> _cars = new();

        [SetUp]
        public void Setup ()
        {
            _cars.Add(new Cars
            {
                Name = "Mercedes",
                Model = "A Class"
            });
        }


        [TearDown]
        public void TearDown ()
        {
            _cars.Clear();
        }

        [Test]
        public void ExportShouldTest ()
        {
            var filePath2 = CsvWriteRead.ExportCsv(_cars, "BBB", @"C:\Users\Perdorues\Desktop\Repository");
            //Console.WriteLine(filePath2);
            var result2 = CsvWriteRead.ReadCsv(filePath2);
            //Console.WriteLine(result2);

            Assert.That(result2.Trim(), Is.EqualTo("Mercedes, A Class"));
        }
    }
}

