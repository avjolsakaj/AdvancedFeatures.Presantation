using AdvancedFeaturesCoding.Exercise15.Classes;

namespace AdvancedFeaturesCoding.Exercise15;

internal class Program
{
    private static void Main (string[] args)
    {
        var rectangle = new Rectangle(2, 2);  // me kontstuktor

        Console.WriteLine($"Perimetri i drejtkendeshit eshte : {rectangle.CalculatePerimeter()}");
        Console.WriteLine($"Siperfaqja e drejtkendeshit eshte : {rectangle.CalculateArea()}");

        var rightTriangle = new RightTriangle(); // me properties
        rightTriangle.X = 2;
        rightTriangle.Y = 3;
        rightTriangle.Z = 4;

        Console.WriteLine($"Perimetri i trekendeshit kendedrejte eshte : {rightTriangle.CalculatePerimeter()}");
        Console.WriteLine($"Siperfaqja e trendeshit kendedrejte eshte : {rightTriangle.CalculateArea()}");

        var generalTriangle = new GeneralTriangle();
        generalTriangle.X = 2;
        generalTriangle.Y = 3;
        generalTriangle.Z = 4;
        generalTriangle.H = 5;

        Console.WriteLine($"Perimetri i trekendendeshit te cfaredoshem eshte : {generalTriangle.CalculatePerimeter()}");
        Console.WriteLine($"Siperfaqja e trekendeshit te cfaredoshem eshte : {generalTriangle.CalculateArea()}");

        var hexagon = new Hexagon
        {
            X = 2,    // inicializim me nje menyr tjeter
        };

        Console.WriteLine($"Perimetri i gjashtekendeshit eshte : {hexagon.CalculatePerimeter()}");
        Console.WriteLine($"Siperfqja e gjashtekendeshit eshte : {hexagon.CalculateArea()}");

        var cone = new Cone
        {
            R = 2,
            H = 3
        };

        Console.WriteLine($"Vellimi i Konit eshte : {cone.CalculateVolume()}");
        Console.WriteLine($"Siperfaqja e Konit eshte : {cone.CalculateArea()}");

        var qube = new Qube(2);

        Console.WriteLine($"Vellimi i kubi eshte : {qube.CalculateVolume()}");
        Console.WriteLine($"Siperfaqja e kubi eshte : {qube.CalculateArea()}");

        Console.WriteLine("-------Fill i Konit (Per Fill = 10)----------------------------------------------------------");

        if (cone.Fill(10) == 1)
        {
            Console.WriteLine("will pour too much water into the figure and overflow");
        }

        if (cone.Fill(10) == 0)
        {
            Console.WriteLine("fill the figure with water to the brim");
        }

        if (cone.Fill(10) == -1)
        {
            Console.WriteLine("not pouring enough water");
        }

        Console.WriteLine("-------Fill i Kubit (Per Fill = 10)----------------------------------------------------------");

        if (qube.Fill(10) == 1)
        {
            Console.WriteLine("will pour too much water into the figure and overflow");
        }

        if (qube.Fill(10) == 0)
        {
            Console.WriteLine("fill the figure with water to the brim");
        }

        if (qube.Fill(10) == -1)
        {
            Console.WriteLine("not pouring enough water");
        }
    }
}