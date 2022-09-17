namespace AdvancedFeatues.Generics;

internal class Program
{
    private static void Main (string[] args)
    {
        //instantiate generic with Integer
        var intObj = new TestClass<int>();

        //adding integer values into collection
        intObj.Add(1);
        intObj.Add(2);
        intObj.Add(3);
        intObj.Add(4);
        intObj.Add(5);

        // What happen if intObj.Add(6);

        //displaying values
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine(intObj[i]);   //No unboxing
        }

        _ = Console.ReadKey();

        //instantiate generic with string
        var stringObj = new TestClass<string>();

        //adding integer values into collection
        stringObj.Add("One");
        stringObj.Add("Two");
        stringObj.Add("Three");
        stringObj.Add("Four");
        stringObj.Add("Five");

        //displaying values
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine(stringObj[i]);   //No unboxing
        }
    }
}

public class TestClass<T>
{
    // define an Array of  5
    private T[] obj = new T[5];
    private int count = 0;

    // adding items
    public void Add (T item)
    {
        //checking length
        if (count + 1 < 6)
        {
            obj[count] = item;

        }
        count++;
    }

    //indexer for foreach statement iteration
    public T this[int index]
    {
        get => obj[index];
        set => obj[index] = value;
    }
}