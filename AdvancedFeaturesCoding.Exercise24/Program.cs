namespace AdvancedFeaturesCoding.Exercise24
{
    internal class Program
    {
        private static void Main (string[] args)
        {
            var carobj = new List<Cars>()
        {
            new Cars()
            {
                Name = "Mercedes",
                Model = "A Class"
            },
            new Cars()
            {
                Name = "Benley",
                Model = "fiks"
            },
            new Cars()
            {
                Name = "Tesla",
                Model = "Model 3"
            },
            new Cars()
            {
                Name = "Mercedes",
                Model = "B Class"
            },
        };

            List<string> cars = new List<string>();
            cars.Add("BMW");
            cars.Add("Ferrari");
            cars.Add("Golf");
            cars.Add("Skoda");
            cars.Add("Fiat");
            cars.Add("Tesla");
            cars.Add("Lambo");
            cars.Add("Mazeratti");
            cars.Add("Aston Martin");
            cars.Add("Toyota");
            cars.Add("Range Rover");
            cars.Add("Porche Carerra");

            Console.WriteLine("Please enter a valid path in which the file will be created: ");
            var path = Console.ReadLine();

            Console.WriteLine("Please enter a name for the file: ");
            var fileName = Console.ReadLine();

            var filePath = CsvWriteRead.ExportCsv(cars, fileName, path);
            Console.WriteLine(filePath);
            var result = CsvWriteRead.ReadCsv(filePath);
            Console.WriteLine(result);

            Console.WriteLine("Please enter a name 2 for the file: ");
            var fileName2 = Console.ReadLine();

            var filePath2 = CsvWriteRead.ExportCsv(carobj, fileName2, path);
            Console.WriteLine(filePath2);
            var result2 = CsvWriteRead.ReadCsv(filePath2);
            Console.WriteLine(result2);
        }
    }
}