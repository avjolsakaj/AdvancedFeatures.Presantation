namespace AdvancedFeaturesCoding.ExerciseTwenty;

public class Joiner<T>
{
    private string _separator;
    public Joiner (string separator)
    {
        _separator = separator;
    }

    public string Join (IEnumerable<T> values)
    {
        var result = string.Empty;
        foreach (var item in values)
        {
            result += item?.ToString() + _separator;
        }
        return result.Remove(result.Length - 1);

        //string.Join(_separator, values);
    }
}