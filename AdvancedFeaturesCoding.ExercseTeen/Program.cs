namespace AdvancedFeaturesCoding.ExercseTeen;

internal class Program
{
    private static void Main (string[] args)
    {
        var listcars = new List<Car>
        {
            new Car
            {
                EType = EngineType.V12,
                Manufacturers = new List<Manufacturer>
                {
                    new Manufacturer("Mercedes",1985,"Germany")
                }
            }
        };
    }

    public class Manufacturer
    {
        private string _MName;
        private int _YearE;
        private string _Country;

        public Manufacturer (string mname, int year, string country)
        {
            _MName = mname;
            _YearE = year;
            _Country = country;
        }

        public override bool Equals (object? obj)
        {
            var input = obj as Manufacturer;
            return _MName == input._MName && _YearE == input._YearE && _Country == input._Country;
        }

        public override int GetHashCode ()
        {
            return _MName.GetHashCode() + _YearE.GetHashCode() + _Country.GetHashCode();
        }
    }
    public enum EngineType
    {
        V12,
        V8,
        V6,
        S6,
        S4,
        S3
    }

    public class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public List<Manufacturer> Manufacturers { get; set; }
        public EngineType EType { get; set; }

        public override bool Equals (object? obj)
        {
            var input = obj as Car;
            return Model == input.Model && Name == input.Name && Price == input.Price && Year == input.Year && Manufacturers == input.Manufacturers && EType == input.EType;
        }

        public override int GetHashCode ()
        {
            return Model.GetHashCode() + Price.GetHashCode() + Year.GetHashCode() + Manufacturers.GetHashCode() + Name.GetHashCode() + EType.GetHashCode();
        }
    }
    public class CarService
    {
        public List<Car> Cars { get; set; }

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

        public List<Car> OrderByDescending ()
        {
            return Cars; //TODO:
        }

        public void CheckSpecificCar ()
        {
        }

        public List<Car> SpecificManufacturer (Manufacturer manufacturer)
        {
            return Cars.Where(x => x.Manufacturers.Contains(manufacturer)).ToList();
        }
    }
}