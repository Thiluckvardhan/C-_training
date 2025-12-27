using Day6;

/// <summary>
/// This the class from where all the calls to the different methods in different classes occur
/// </summary>
class Program
{
    static void Main()
    {
        // The Inherited class must implement all the method which are defined inside the Interface class 
        // Interface Example
        // Printer p=new Printer();
        // p.PrintName("Thiluck");

        // Multiple Inheritance Example

        // Visitor vis = new Visitor();
        // vis.NonVegeats();
        // vis.Vegeats();

        // If you have two Methods with same name inside a multiple inherited class do this 

        // IVegEatter veg = new Visitor();
        // INonVegEatter nonveg = new Visitor();

        // veg.GetTaste();
        // nonveg.GetTaste();

        HOD hod=new HOD(1,"Thiluck");
        
    }
}