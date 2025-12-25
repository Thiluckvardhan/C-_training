namespace Day6
{
    #region Interfaces

    /// <summary>
    /// Interface for vegetarian eating behavior
    /// </summary>
    interface IVegEatter
    {
        /// <summary>
        /// Method to consume vegetarian food
        /// </summary>
        public void Vegeats();

        /// <summary>
        /// Method to get taste description of vegetarian food
        /// </summary>
        public void GetTaste();
    }

    /// <summary>
    /// Interface for non-vegetarian eating behavior
    /// </summary>
    interface INonVegEatter
    {
        /// <summary>
        /// Method to consume non-vegetarian food
        /// </summary>
        public void NonVegeats();

        /// <summary>
        /// Method to get taste description of non-vegetarian food
        /// </summary>
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

        /// <summary>
        /// Implementation of non-vegetarian eating from INonVegEatter interface
        /// </summary>
        public void NonVegeats()
        {
            Console.WriteLine("Visitor ate NonVeg Food");
        }

        /// <summary>
        /// Implementation of GetTaste for non-vegetarian food from INonVegEatter interface
        /// </summary>
        void INonVegEatter.GetTaste()
        {
            Console.WriteLine("Getting Nonveg Taste");
        }

        #endregion

        #region Vegetarian Implementation

        /// <summary>
        /// Implementation of vegetarian eating from IVegEatter interface
        /// </summary>
        public void Vegeats()
        {
            Console.WriteLine("Visitor ate Veg Food");
        }

        /// <summary>
        /// Implementation of GetTaste for vegetarian food from IVegEatter interface
        /// </summary>
        void IVegEatter.GetTaste()
        {
            Console.WriteLine("Getting Veg Taste");
        }

        #endregion
    }

    #endregion
}