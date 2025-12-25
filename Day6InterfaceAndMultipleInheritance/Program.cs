using Day6;

class Program
{
    static void Main()
    {
        // The Inherited class must implement all the method which are defined inside the Interface class 
        // Interface Example
        // Printer p=new Printer();
        // p.PrintName("Thiluck");

        // Multiple Inheritance Example

        Visitor vis=new Visitor();
        vis.NonVegeats();
        vis.Vegeats();

        // If you have two Methods with same name inside a multiple inherited class do this 

        IVegEatter veg=new Visitor();
        INonVegEatter nonveg=new Visitor();

        veg.GetTaste();
        nonveg.GetTaste();
    }
}