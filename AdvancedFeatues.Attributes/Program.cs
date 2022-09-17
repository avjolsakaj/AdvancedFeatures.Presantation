namespace AdvancedFeatues.Attributes;

internal class Program
{
    private static void Main (string[] args)
    {
        var att = new WithAttributes();
        att.Name = "";
        att.Age = 29;

        _ = att.GetAge();
    }
}

[Serializable]
public class WithAttributes
{
    [Obsolete]
    public string Name { get; set; }

    public string Description { get; set; }

    public int Age { get; set; }

    [Obsolete]
    public int GetAge ()
    {
        return Age;
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