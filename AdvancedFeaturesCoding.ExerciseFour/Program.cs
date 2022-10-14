namespace AdvancedFeaturesCoding.ExerciseFour;

internal class Program
{
    private static void Main (string[] args)
    {
        // Add item to storage
        var storage = new Storage();
        storage.AddToStorage("avjol", "Html");
        storage.AddToStorage("avjol", "Css");
        storage.AddToStorage("avjol", "JS");
        storage.AddToStorage("avjol", "C#");
        storage.AddToStorage("sakaj", "C#");
        storage.AddToStorage("sakaj", "Sql");
        storage.AddToStorage("sakaj", "TS");

        // Print values
        Console.WriteLine("Find by key:");
        storage.PrintValues("avjol");

        Console.WriteLine();

        // Print key
        Console.WriteLine("Find by value:");
        storage.FindValues("C#");

        Console.WriteLine();

        Console.WriteLine("Unknown value:");
        storage.FindValues("C++");
    }

    public class Storage
    {
        private readonly Dictionary<string, List<string>> _map;

        public Storage ()
        {
            _map = new Dictionary<string, List<string>>();
        }

        public void AddToStorage (string key, string value)
        {
            // It contains the key,
            if (_map.ContainsKey(key))
            {
                // we need get values,
                var values = _map[key];

                // update values
                values.Add(value);

                // update dictionary
                _map[key] = values;

                return;
            }

            // Doesn't contain the key, so we just add new key-value pair
            _map[key] = new List<string> { value };

        }

        public void PrintValues (string key)
        {
            // will print list of elements under this key

            _ = _map.TryGetValue(key, out var values);

            if (values?.Any() == false)
            {
                Console.WriteLine($"There are no values for key: {key}");
            }

            Console.WriteLine($"Key: {key}, {string.Join(",", values)}");
        }

        public void FindValues (string value)
        {
            // will return list of keys with this value
            var existing = _map.Where(x => x.Value.Contains(value, StringComparer.OrdinalIgnoreCase)).ToList();

            if (existing?.Any() == false)
            {
                Console.WriteLine($"There is no key for value: {value}");
            }

            foreach (var item in existing)
            {
                Console.WriteLine($"Key: {item.Key}, {string.Join(",", item.Value)}");
            }
        }
    }
}