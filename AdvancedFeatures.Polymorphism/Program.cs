namespace AdvancedFeatures.Polymorphism;

internal class Program
{
    private static void Main (string[] args)
    {
        var dog = new Dog();
        dog.Age = 2;
        dog.Name = "Bali";  // set;

        var dogName = dog.Name; // get;

        dog.Name = "Cookie"; // set;
        dogName = dog.Name; // get;

        //var dog = new Dog
        //{
        //    Age = 2,
        //    Name = "Bali"
        //};

        dog.GetName();
        //Operation.Call(dog);

        var cat = new Cat
        {
            Age = 5,
            Name = "Lusika"
        };

        cat.GetName();

        //Operation.Call(cat);

        Operation.Call();

        _ = Console.ReadLine();
    }
}

public class Animal
{
    public string Name { get; set; }

    public int Age { get; set; }

    public virtual void GetName ()
    {
        Console.WriteLine("This method can be overriden");
    }
}

public class Dog : Animal
{
    public override void GetName ()
    {
        Console.WriteLine($"Dog name is {Name}, and age is {Age}");

        base.GetName();
    }
}

public class Cat : Animal
{
    public override void GetName ()
    {
        Console.WriteLine($"Cat name is {Name}, and age is {Age}");
    }
}

public class Operation
{
    public static void Call (Dog dog)
    {
        Console.WriteLine($"Dog is called, {dog.Age}");
    }

    public static void Call (Cat cat)
    {
        Console.WriteLine($"Cat is called, {cat.Age}");
    }

    public static void Call ()
    {
        Console.WriteLine("Do nothing!");
    }
}