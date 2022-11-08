namespace AdvancedFeaturesCoding.ExerciseTwentyOne;

public class ExtendedListDefault<T> : List<T>
{
    public ExtendedListDefault (List<T> inputList) : base(inputList)
    {
    }

    public List<T> GetEveryNthElement (int startIndex, int skip)
    {
        var outputList = new List<T>();
        for (var i = startIndex; i < Count - 1; i += skip)
        {
            if (i > Count - 1)
            {
                break;
            }

            outputList.Add(this[i]);
        }
        return outputList;
    }
}