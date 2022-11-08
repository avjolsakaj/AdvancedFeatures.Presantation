namespace AdvancedFeaturesCoding.ExerciseTwentyOne;

public class ExtendedList<T> : List<T>
{
    private readonly List<T> _inputList;

    public ExtendedList (List<T> inputList)
    {
        _inputList = inputList;
    }

    public List<T> GetEveryNthElement (int startIndex, int skip)
    {
        var outputList = new List<T>();
        for (var i = startIndex; i < _inputList.Count - 1; i = i + skip)
        {
            if (i > _inputList.Count - 1)
            {
                break;
            }
            outputList.Add(_inputList[i]);
        }
        return outputList;
    }
}
