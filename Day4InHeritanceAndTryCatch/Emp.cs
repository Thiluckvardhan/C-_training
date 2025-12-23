using System;

namespace Day4
{
    /// <summary>
    /// Represents an employee with validation logic for ID, name, and salary.
    /// Throws ArgumentException if validation fails.
    /// </summary>
    public class Emp
    {
        #region Fields
        // Employee identifier
        private int Id;
        // Employee salary
        private int Salary;
        // Employee name
        private String Name;
        // Accumulated validation error messages
        string throw_exception;
        #endregion
        // public int id
        // {
        //     set
        //     {
        //         if (value > 0) Id = value;
        //         else
        //         {
        //             Id = 0;
        //             throw new InvalidOperationException("Id must be greater than 0");
        //         }
        //     }
        // }

        #region Constructors
        /// <summary>
        /// Initializes a new employee with validation.
        /// </summary>
        /// <param name="id">Employee ID (must be non-negative).</param>
        /// <param name="name">Employee name (must not be null or empty).</param>
        /// <param name="salary">Employee salary (must be non-negative).</param>
        /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
        public Emp(int id, String name, int salary)
        {
            // Validate ID
            if (id < 0)
            {
                throw_exception = "Id is invalid ";
            }
            // Validate name
            if (string.IsNullOrEmpty(name))
            {
                throw_exception += " Name should not be Null";
            }
            // Validate salary
            if (salary < 0)
            {
                throw_exception += " Salary Should not be Negative";
            }
            // Throw exception if any validation failed
            if (!string.IsNullOrEmpty(throw_exception))
            {
                throw new ArgumentException(throw_exception);
            }
            else
            {
                this.Id = id;
                this.Name = name;
                this.Salary = salary;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Prints employee details to the console.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine($"Id is {Id} Name {Name} Salary {Salary}");
        }
        #endregion
    }
}