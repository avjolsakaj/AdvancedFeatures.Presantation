using AdvancedFeaturesCoding.Shared.Implementations;

namespace AdvancedFeaturesCoding.ExerciseOne.Tests;

internal class CircleShould
{
    private Circle? _circle;

    [SetUp]
    public void SetUp ()
    {
        // Arrange
        var center = new Point2D(1, 1);
        var point = new Point2D(2, 1);

        _circle = new Circle(center, point);
    }

    [TearDown]
    public void TearDown ()
    {
        _circle = null;
    }

    [Test]
    public void ShouldReturnRadius ()
    {
        // Assert
        Assert.That(_circle.GetRadius(), Is.EqualTo(1));
    }

    [Test]
    public void ShouldNotReturnWrongRadius ()
    {
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(_circle.GetRadius(), Is.Not.LessThan(1));
            Assert.That(_circle.GetRadius(), Is.Not.GreaterThan(1));
        });
    }

    [Test]
    public void ShouldReturnDiameter ()
    {
        // Assert
        Assert.That(_circle.GetDiameter(), Is.EqualTo(2));
    }

    [Test]
    public void ShouldReturnPerimeter ()
    {
        // Assert
        Assert.That(Math.Round(_circle.GetPerimeter(), 1), Is.EqualTo(6.3));
    }
}
