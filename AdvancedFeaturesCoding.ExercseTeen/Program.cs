namespace AdvancedFeaturesCoding.ExerciseTeen;

internal class Program
{
    private static void Main (string[] args)
    {
        var c1 = new Car
        {
            EType = EngineType.V12,
            Name = "Mercedes Benz",
            Model = "S Class",
            Price = 75000,
            Year = 2020
        };

        var c2 = new Car
        {
            EType = EngineType.V6,
            Name = "Mercedes Benz",
            Model = "E Class",
            Price = 25000,
            Year = 2019
        };

        var c3 = new Car
        {
            EType = EngineType.S4,
            Name = "Supra",
            Model = "Economic",
            Price = 200000,
            Year = 2023
        };

        var c4 = new Car
        {
            EType = EngineType.V6,
            Name = "BMW",
            Model = "7 Series",
            Price = 80000,
            Year = 2021
        };

        var c5 = new Car
        {
            EType = EngineType.V12,
            Name = "BMW",
            Model = "5 Series",
            Price = 75000,
            Year = 2021
        };

        // Adding cars to the list, 
        var carService = new CarService();
        carService.AddCar(c1);
        carService.AddCar(c2);
        carService.AddCar(c3);
        carService.AddCar(c4);
        carService.AddCar(c5);

        // Removing a car from the list, 
        carService.RemoveCar(c3);

        // Returning a list of all cars,
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("All cars are listed below:");

        var newCars = carService.GetCars();

        foreach (var car in newCars)
        {
            Console.WriteLine($"Name: {car.Name}, Engine Type: {car.EType}, Model: {car.Model}, Price: {car.Price}, Year of Production: {car.Year}");
            Console.WriteLine("___________________________________________________________________________________________________________________");

        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This method returns the Vehicles with Specific Engine:");

        // Returning cars with a V12 engine
        var newVehicle = carService.GetCarsWithEngineType(EngineType.V12);
        foreach (var car in newVehicle)
        {
            Console.WriteLine($"Name: {car.Name}, Engine Type: {car.EType}, Model: {car.Model}, Price: {car.Price}, Year of Production: {car.Year}");
            Console.WriteLine("___________________________________________________________________________________________________________________");

        }

        // Returning cars produced before after 2020 
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This method returns the Vehicles listed by the Manufacture Year >2020:");

        var manufactureYear = carService.GetCarsNewerThan(2020);
        foreach (var car in manufactureYear)
        {
            Console.WriteLine(car.ToString());
            Console.WriteLine("___________________________________________________________________________________________________________________");
        }

        // Returning the most expensive car
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This method returns the most Expensive Car:");

        var mostExpensive = carService.GetMostExpensiveCar();
        Console.WriteLine(mostExpensive.ToString());
        Console.WriteLine("___________________________________________________________________________________________________________________");

        // Returning the cheapest car
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("This method returns the cheapest Car:");

        var leastExpensive = carService.GetCheapestCar();
        Console.WriteLine($"Name: {leastExpensive.Name}, Engine Type: {leastExpensive.EType}, Model: {leastExpensive.Model}, Price: {leastExpensive.Price}, Year of Production: {leastExpensive.Year}");
        Console.WriteLine("___________________________________________________________________________________________________________________");

        // Returning a list of all cars sorted according to the passed parameter: ascending / descending
        Console.WriteLine("This method returns the Ordered list as per Manufacture Production Year:");

        var list = carService.Order("ascending");
        Console.WriteLine();

        foreach (var car in list)
        {
            Console.WriteLine($"Year of Production: {car.Year}");
            Console.WriteLine("___________________________________________________________________________________________________________________");
        }

        // Checking if a specific car is on the list
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Checking if a specific car is on the list, returning back True or False:");

        var istrue = carService.ContainsSPecificCar(c1);
        Console.WriteLine(istrue);

    }
}