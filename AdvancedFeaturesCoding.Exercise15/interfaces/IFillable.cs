namespace AdvancedFeaturesCoding.Exercise15.interfaces;
//exercise 17
//create a fillable interface with the fill() method.implement the method
//in the 3dshape class from the previous task or separately in the cone
//and qube classes.
//the fill() method should take a parameter, e.g. int, and check whether
//after the action of filling the figure:
//• will pour too much water into the figure and overflow,
//• fill the figure with water to the brim,
//• not pouring enough water.
//for each situation, it should write the status information in the console.
//use the calculatevolume() method.

public interface IFillable
{
    int Fill (int quantity);
}
