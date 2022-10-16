using AdvancedFeaturesCoding.Shared.Implementations;

namespace AdvancedFeaturesCoding.ExerciseFive;

internal class Program
{
    private static void Main (string[] args)
    {
        var center = new Point2D(1, 2);

        var point = new Point2D(4, 5);

        var circle = new Circle(center, point);

        Console.WriteLine($"Center: {center}");

        Console.WriteLine($"Point: {point}");

        Console.WriteLine($"Radius: {circle.GetRadius()}");

        Console.WriteLine($"Diameter: {circle.GetDiameter()}");

        Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

        Console.WriteLine($"Area: {circle.GetArea()}");

        foreach (var item in circle.GetSlicePoints())
        {
            Console.WriteLine($"Point: {item.X} {item.Y}");
        }

        var moveDirection = new MoveDirection(5, 10);

        circle.Move(moveDirection);

        Console.WriteLine($"========================================");

        Console.WriteLine($"Center: {center}");

        Console.WriteLine($"Point: {point}");

        Console.WriteLine($"Radius: {circle.GetRadius()}");

        Console.WriteLine($"Diameter: {circle.GetDiameter()}");

        Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

        Console.WriteLine($"Area: {circle.GetArea()}");

        foreach (var item in circle.GetSlicePoints())
        {
            Console.WriteLine($"Point: {item.X} {item.Y}");
        }

        Console.WriteLine($"========================================");

        circle.Resize(2);

        Console.WriteLine($"Center: {center}");

        Console.WriteLine($"Point: {point}");

        Console.WriteLine($"Radius: {circle.GetRadius()}");

        Console.WriteLine($"Diameter: {circle.GetDiameter()}");

        Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

        Console.WriteLine($"Area: {circle.GetArea()}");

        foreach (var item in circle.GetSlicePoints())
        {
            Console.WriteLine($"Point: {item.X} {item.Y}");
        }

        _ = Console.ReadLine();
    }
}
