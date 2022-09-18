namespace AdvancedFeatues.Attributes;

internal class Program
{
    private static void Main (string[] args)
    {
        var people = new People();
        //people.Name= "Avjol Sakaj";   // Obsolete

        people.FirstName = "Avjol";
        people.LastName = "Sakaj";
        people.Age = 29;

        _ = people.GetName();
    }
}

[Serializable]
public class People
{
    //[Obsolete]
    //public string Name { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Description { get; set; }

    public int Age { get; set; }

    //[Obsolete]
    //public string GetName ()
    //{
    //    return Name;
    //}

    public string GetName ()
    {
        return $"{FirstName} {LastName}";
    }
}

internal class DisplayNameAttribute : Attribute
{
    public string Name { get; }

    public DisplayNameAttribute (string name)
    {
        Name = name;
    }
}

internal enum Fruit
{
    [DisplayName("Green Ligol Apple")]
    Apple,

    [DisplayName("Sweet Orange")]
    Orange,

    [DisplayName("Sour Lemon")]
    Lemon
}