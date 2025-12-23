using System;

namespace Day5
{
    /// <summary>
    /// Abstract base class for employee tax calculation.
    /// </summary>
    public abstract class Employee1
    {
        #region Abstract Methods
        /// <summary>
        /// Calculates tax for the employee. Must be implemented by derived classes.
        /// </summary>
        public abstract void CalcTax();
        #endregion
    }
    /// <summary>
    /// Indian employee with India-specific tax calculation.
    /// </summary>
    public class IndianEmployee:Employee1
    {
        #region Methods
        /// <summary>
        /// Implements tax calculation for Indian employees.
        /// </summary>
        public override void CalcTax()
        {
            Console.WriteLine("IndianEmployee Tax is Calculated");
        }
        #endregion
    }
    /// <summary>
    /// US employee with US-specific tax calculation.
    /// </summary>
    public class USEmployee : Employee1
    {
        #region Methods
        /// <summary>
        /// Implements tax calculation for US employees.
        /// </summary>
        public override void CalcTax()
        {
            Console.WriteLine("USEmployee Tax is Calculated");
        }
        #endregion
    }
}