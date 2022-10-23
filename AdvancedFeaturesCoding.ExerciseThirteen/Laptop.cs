namespace AdvancedFeaturesCoding.ExerciseThirteen;

public class Laptop : Computer
{
    public string Battery { get; set; }

    public override string ToString ()
    {
        return $"{base.ToString()}, Battery : {Battery}";
    }
}