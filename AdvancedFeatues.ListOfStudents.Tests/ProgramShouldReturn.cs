using AdvancedFeatures.ListOfStudents;

namespace AdvancedFeatues.ListOfStudents.Tests
{
    public class ProgramShouldReturn
    {
        private readonly List<Student> _students = new();

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
        public void ListOfStudents_Passed ()
        {
            var passed = _students.Where(x => x.HavePassed());

            Assert.That(passed.Any(), Is.True);

            Assert.That(passed.Count(), Is.EqualTo(4));
        }

        [Test]
        public void ListOfStudents_Failed ()
        {
            var notPassed = _students.Where(x => !x.HavePassed());

            Assert.That(notPassed.Any(), Is.True);

            Assert.That(notPassed.Count(), Is.EqualTo(2));
        }

        [Test]
        public void ListOfStudents_Excellent ()
        {
            var excellent = _students.Where(x => x.IsExellent());

            Assert.That(excellent.Any(), Is.True);

            Assert.That(excellent.Count(), Is.EqualTo(1));
        }

        [Test]
        public void ListOfStudents_NotExcellent ()
        {
            var notExcellent = _students.Where(x => x.IsExellent());

            Assert.That(notExcellent.Any(), Is.True);

            Assert.That(notExcellent.Count(), Is.EqualTo(1));
        }
    }
}