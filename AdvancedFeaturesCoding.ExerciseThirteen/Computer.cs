namespace AdvancedFeaturesCoding.ExerciseThirteen;

public class Computer
{
    public string Processor { get; set; }
    public string Ram { get; set; }
    public string GPU { get; set; }
    public string Company { get; set; }
    public string Model { get; set; }

    public override bool Equals (object? obj)
    {
        var input = obj as Computer;

        return Processor == input.Processor && Ram == input.Ram && GPU == input.GPU && Company == input.Company && Model == input.Model;
    }
    public override int GetHashCode ()
    {
        return Processor.GetHashCode() + Ram.GetHashCode() + GPU.GetHashCode() + Company.GetHashCode() + Model.GetHashCode();
    }

    public override string ToString ()
    {
        return $"Processor : {Processor}, Ram : {Ram} , GPU : {GPU} , Company :  {Company} , Model : {Model}";
    }
}