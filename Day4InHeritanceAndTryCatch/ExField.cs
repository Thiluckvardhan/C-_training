using System;

namespace Day4
{
    /// <summary>
    /// Demonstrates exception handling in property setters.
    /// </summary>
    public class ExField
    {
        #region Fields
        // Private backing field for employee ID
        private int id;
        #endregion
        
        #region Properties
        /// <summary>
        /// Sets the employee ID with validation.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when ID is not greater than 0.</exception>
        public int Id
        {
            set
            {
                if(value>0)id=value;
                else
                {
                    id=0;
                    throw new InvalidOperationException("Id must be greater than 0");
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a formatted string displaying the employee ID.
        /// </summary>
        /// <returns>Employee details string.</returns>
        public string DisplayEmpDetails()
        {
            return $"Employee Id is {id}";
        }
        #endregion
    }
}