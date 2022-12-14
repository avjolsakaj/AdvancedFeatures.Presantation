using AdvancedFeaturesCoding.Shared.Implementations;

namespace AdvancedFeaturesCoding.ExerciseOne.Tests;

public class OrderDecendingShould
{
    private List<string> _listStrings;

    [SetUp]
    public void Setup ()
    {
        // Arrange
        _listStrings = new List<string>
        {
            "Bla Bla",
            "Lumturi",
            "Antonio"
        };
    }

    [TearDown]
    public void TearDown ()
    {
        // Arrange
        _listStrings.Clear();
    }

    [Test]
    public void OrderListDec ()
    {
        // Act
        var result = Helpers.OrderDescendingAlphabetically(_listStrings);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.FirstOrDefault(), Is.EqualTo("Lumturi"));
            Assert.That(result.LastOrDefault(), Is.EqualTo("Antonio"));
        });
    }

    [Test]
    public void NotOrderListAsc ()
    {
        // Act
        var result = Helpers.OrderDescendingAlphabetically(_listStrings);

        // Assert
        Assert.That(result.FirstOrDefault(), Is.Not.EqualTo("Antonio"));
        Assert.That(result.LastOrDefault(), Is.Not.EqualTo("Lumturi"));
    }
}