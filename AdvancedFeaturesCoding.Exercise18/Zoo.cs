namespace AdvancedFeaturesCoding.Exercise18;

public class Zoo
{
    private Dictionary<string, int> _animals;

    public Zoo (Dictionary<string, int> animals)

    {
        _animals = animals;
    }

    public int GetNumberOfAllAnimals ()

    {
        var total = _animals.Sum(v => v.Value);
        return total;
    }

    public Dictionary<string, int> GetAnimalsCount ()
    {
        return _animals;
    }

    public Dictionary<string, int> GetAnimalsCountSorted ()
    {
        return _animals.OrderByDescending(key => key.Value).ToDictionary(x => x.Key, x => x.Value);
    }

    public void AddAnimals (string s, int i)
    {
        if (_animals.ContainsKey(s))
        {
            _animals[s] = _animals[s] + i;
        }
        else
        {
            _animals.Add(s, i);
        }
    }
}

