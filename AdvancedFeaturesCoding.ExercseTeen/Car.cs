namespace AdvancedFeaturesCoding.ExerciseTeen;

public class Car
{
    public string Name;
    public string Model;
    public int Price;
    public int Year;
    public List<Manufacturer> Manufacturers;
    public EngineType EType;

    public override bool Equals (object? obj)
    {
        var input = obj as Car;
        return Model == input.Model && Name == input.Name && Price == input.Price && Year == input.Year && Manufacturers == input.Manufacturers && EType == input.EType;
    }

    public override int GetHashCode ()
    {
        return Model.GetHashCode() + Price.GetHashCode() + Year.GetHashCode() + Manufacturers.GetHashCode() + Name.GetHashCode() + EType.GetHashCode();
    }

    public override string ToString ()
    {
        return $"Name: {Name}, Engine Type: {EType}, Model: {Model}, Price: {Price}, Year of Production: {Year}";
    }
}
