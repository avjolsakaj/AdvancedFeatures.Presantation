namespace AdvancedFeaturesCoding.ExerciseTeen;

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
