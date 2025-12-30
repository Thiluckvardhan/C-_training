using System;

namespace Day3
{
    /// <summary>
    /// Associates an employee with a competition they won.
    /// </summary>
    class CompetionWon
    {
        #region Fields
        // Employee who won the competition
        Employee emp;
        // Competition that was won
        Competion com;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance linking an employee to a competition.
        /// </summary>
        /// <param name="Emp">The employee who won.</param>
        /// <param name="Com">The competition that was won.</param>
        public CompetionWon(Employee Emp, Competion Com)
        {
            emp = Emp;
            com = Com;
        }
        #endregion
    }
}