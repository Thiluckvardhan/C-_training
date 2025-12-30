namespace Day6
{
    #region Interfaces

    /// <summary>
    /// Interface for vegetarian eating behavior
    /// </summary>
    interface IVegEatter
    {
        // Method to consume vegetarian food
        public void Vegeats();

        // Method to get taste description of vegetarian food
        public void GetTaste();
    }

    /// <summary>
    /// Interface for non-vegetarian eating behavior
    /// </summary>
    interface INonVegEatter
    {
        // Method to consume non-vegetarian food
        public void NonVegeats();

        // Method to get taste description of non-vegetarian food
        public void GetTaste();
    }

    #endregion

    #region Visitor Class

    /// <summary>
    /// Visitor class that implements both vegetarian and non-vegetarian eating interfaces
    /// Demonstrates multiple interface implementation in C#
    /// </summary>
    public class Visitor : INonVegEatter, IVegEatter
    {
        #region Non-Vegetarian Implementation

        // Implementation of non-vegetarian eating from INonVegEatter interface
        public void NonVegeats()
        {
            Console.WriteLine("Visitor ate NonVeg Food");
        }

        // Implementation of GetTaste for non-vegetarian food from INonVegEatter interface
        void INonVegEatter.GetTaste()
        {
            Console.WriteLine("Getting Nonveg Taste");
        }

        #endregion

        #region Vegetarian Implementation

        // Implementation of vegetarian eating from IVegEatter interface
        public void Vegeats()
        {
            Console.WriteLine("Visitor ate Veg Food");
        }

        // Implementation of GetTaste for vegetarian food from IVegEatter interface
        void IVegEatter.GetTaste()
        {
            Console.WriteLine("Getting Veg Taste");
        }

        #endregion
    }

    #endregion
}