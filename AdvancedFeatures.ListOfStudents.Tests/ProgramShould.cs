using NUnit.Framework;

namespace AdvancedFeatures.ListOfStudents;

internal class ProgramShould
{
    private List<Student> _students = new();

    [SetUp]
    public void Setup ()
    {
        _students.AddRange(new List<Student>
        {
            new Student{ Name = "Passed 1", Surname = "Student", Grade = 5 },
            new Student{ Name = "Passed 2", Surname = "Student", Grade = 7 },
            new Student{ Name = "Exellent", Surname = "Perfect", Grade = 10 },
            new Student{ Name = "Good", Surname = "Student", Grade = 9 },
            new Student{ Name = "Fail 1", Surname = "Student", Grade = 4 },
            new Student{ Name = "Fail 2", Surname = "Student", Grade = 3 }
        });
    }

    [TearDown]
    public void TearDown ()
    {
        _students.Clear();
    }

    [Test]
    public void Return_ListOfStudents_Passed ()
    {
        var notPassed = _students.Where(x => !x.HavePassed());

        Assert.True(notPassed.Any());

        Assert.IsTrue(notPassed.Count() == 2);
    }
}
