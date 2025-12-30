using System;

namespace Day4
{
    /// <summary>
    /// Demonstrates constructor-based initialization and computation.
    /// Adds two numbers and stores the result during construction.
    /// </summary>
    public class AddtwoNumbersusingConstructor
    {
        #region Properties
        // First number
        int Num1 { get; set; }
        // Second number
        int Num2 { get; set; }
        // Computed sum
        int result { get; }
        #endregion

        #region Constructors
        /// <summary>
        /// Private default constructor to prevent parameterless instantiation.
        /// </summary>
        private AddtwoNumbersusingConstructor()
        {
        }
        /// <summary>
        /// Initializes a new instance and computes the sum of two numbers.
        /// </summary>
        /// <param name="num1">First number to add.</param>
        /// <param name="num2">Second number to add.</param>
        public AddtwoNumbersusingConstructor(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            result = Num1 + Num2;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Prints the sum of the two numbers to the console.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Num1 + Num2);
        }
        #endregion
    }
}
