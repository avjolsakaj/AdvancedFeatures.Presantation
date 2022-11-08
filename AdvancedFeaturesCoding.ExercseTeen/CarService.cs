namespace AdvancedFeaturesCoding.ExerciseTeen;

public class CarService
{
    public List<Car> Cars;

    public CarService ()
    {
        Cars = new List<Car>();
    }

    public void AddCar (Car car)
    {
        Cars.Add(car);
    }

    public void RemoveCar (Car car)
    {
        _ = Cars.Remove(car);
    }

    public List<Car> GetCars ()
    {
        return Cars;
    }

    public List<Car> GetCarsWithEngineType (EngineType engineType)
    {
        return Cars.Where(x => x.EType == engineType).ToList();

    }
    public List<Car> GetCarsNewerThan (int year)
    {
        return Cars.Where(x => x.Year > year).ToList();
    }

    public Car GetMostExpensiveCar ()
    {
        return Cars.MaxBy(x => x.Price);
    }

    public Car GetCheapestCar ()
    {
        return Cars.MinBy(x => x.Price);
    }
    public List<Car> GetCarsWithThreeManufacturers ()
    {
        return Cars.Where(x => x.Manufacturers.Count > 3).ToList();
    }

    public List<Car> Order (string order)
    {
        if (order == "ascending")
        {
            return Cars.OrderBy(x => x.Year).ToList();
        }
        else
        {
            return Cars.OrderByDescending(x => x.Year).ToList();
        }
    }
    public void CheckSpecificCar ()
    {

    }

    public List<Car> SpecificManufacturer (Manufacturer manufacturer)
    {
        return Cars.Where(x => x.Manufacturers.Contains(manufacturer)).ToList();
    }

    public bool ContainsSPecificCar (Car car)
    {
        return Cars.Contains(car);
    }
}
