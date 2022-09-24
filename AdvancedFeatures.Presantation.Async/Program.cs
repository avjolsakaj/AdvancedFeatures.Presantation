namespace AdvancedFeatures.Presantation.Async;

internal class Program
{
    private static void Main (string[] args)
    {
        var classRoom = new ClassRoom
        {
            Peoples = new List<People>
            {
                new People
                {
                    Name = "Nikolin",
                    Age = 24
                },

                new People
                {
                    Name = "Geri",
                    Age = 21
                },

                new People
                {
                    Name = "Fredi",
                    Age = 27
                },

                new People
                {
                    Name = "Gesiana",
                    Age = 22
                }
            }
        };

        var peoplesBiggerThan22 = classRoom.GetPeoplesBiggerThan(22);

        foreach (var people in peoplesBiggerThan22)
        {
            Console.WriteLine(people.Name);
        }

        // This will not wait for execution
        _ = classRoom.GetPeoplesBiggerThanAsync(22);

        Console.WriteLine("This is after getting people");

        _ = Console.ReadLine();
    }
}

public class ClassRoom
{
    public List<People> Peoples { get; set; }

    public List<People> GetPeoplesBiggerThan (int age)
    {
        return Peoples.Where(x => x.Age > age).ToList();
    }

    public async Task<List<People>> GetPeoplesBiggerThanAsync (int age)
    {
        // This is entity framework context, later in lections
        //return context.Peoples.Where(x => x.Age > age).ToListAsync()

        return await Task.Run(async () =>
        {
            await Task.Delay(5000);
            //Thread.Sleep(2000);
            Console.WriteLine("This is going to run late!");
            return GetPeoplesBiggerThan(age);
        });
    }
}

public class People
{
    public int Age { get; set; }

    public string Name { get; set; }
}