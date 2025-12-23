using System;

namespace Day3
{
    /// <summary>
    /// Represents a student with identifier and name.
    /// </summary>
    public class Student
    {
        #region Fields
        // Student identifier
        public int Id;
        // Student name
        public String Name;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance with default values.
        /// </summary>
        public Student()
        {
            Id = 0;
            Name = String.Empty;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a formatted string containing student details.
        /// </summary>
        /// <returns>Student ID and name as a string.</returns>
        public String GetDetails()
        {
            return "Id " + Id + "Name " + Name;
        }
        #endregion
    }
}
