namespace AdvancedFeatures.ListOfStudents;

internal class Program
{
    private static void Main (string[] args)
    {
        var students = new List<Student>
        {
            new Student
            {
                Name = "Passed 1",
                Surname = "Student",
                Grade = 5
            },
            new Student
            {
                Name = "Passed 2",
                Surname = "Student",
                Grade = 7
            },
            new Student
            {
                Name = "Exellent",
                Surname = "Perfect",
                Grade = 10
            },
            new Student
            {
                Name = "Good",
                Surname = "Student",
                Grade = 9
            },
            new Student
            {
                Name = "Fail 1",
                Surname = "Student",
                Grade = 4
            },
            new Student
            {
                Name = "Fail 2",
                Surname = "Student",
                Grade = 3
            }
        };

        Console.WriteLine($"Failed:");
        foreach (var student in students.Where(x => !x.HavePassed()))
        {
            Console.WriteLine($"{student.Name}, your grade is {student.Grade}, and you have not passed! You can do better next time.");
        }
        Console.WriteLine();

        Console.WriteLine($"Exellent:");
        foreach (var student in students.Where(x => x.IsExellent()))
        {
            Console.WriteLine($"{student.Name}, your grade is {student.Grade}, and you are exellent! Good job.");
        }
        Console.WriteLine();

        Console.WriteLine($"Average grade is {students.Average(x => x.Grade)}");

        Console.WriteLine();

        Console.WriteLine("Ordered:");
        foreach (var student in students.OrderByDescending(x => x.Grade))
        {
            Console.WriteLine($"{student.Name}, {student.Grade}");
        }
        Console.WriteLine();

        _ = Console.ReadLine();
    }
}

public class Student : IStudent
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public int Grade { get; set; }

    public bool HavePassed () => Grade > 4;

    public bool IsExellent () => Grade > 9;
}

public interface IStudent
{
    bool HavePassed ();

    bool IsExellent ();
}