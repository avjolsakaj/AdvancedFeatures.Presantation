/*Implement the following functionalities based on 100,000 element arrays
with randomly selected values:
1. return a list of unique items,
2. return a list of elements that have been repeated at least once in the
generated array,
3. return a list of the 25 most frequently recurring items.
Implement a method that deduplicates items in the list. If a duplicate is
found, it replaces it with a new random value that did not occur before.
Check if the method worked correctly by calling method number 2. */

namespace AdvancedFeaturesCoding.Exercise12
{
    public class Functionality
    {
        public List<int> UniqueItem (int[] arr)

        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (!res.ContainsKey(item))
                {
                    res.Add(item, 1);
                }
                else
                {
                    res[item]++;
                }
            }
        }

        public List<int> DistinctItem (int[] arr)
        {
            var lista = new List<int>();

            foreach (var item in arr)
                lista.Add(item);

            var DistinctLista = lista.Distinct().ToList();

            return DistinctLista;
        }











    }
}
