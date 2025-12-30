using System;

namespace Day3
{
    /// <summary>
    /// Represents an employee with identifier and name.
    /// </summary>
    public class Employee
{
    #region Fields
    // Employee identifier
    int Emp_Id;
    // Employee name
    String Emp_Name;
    #endregion
    
    #region Constructors
    /// <summary>
    /// Initializes a new instance with default values.
    /// </summary>
    public Employee()
    {
        Emp_Id=0;
        Emp_Name=String.Empty;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Returns a formatted string containing employee details.
    /// </summary>
    /// <returns>Employee ID and name as a string.</returns>
    public String GetDetails()
    {
        return "Id "+Emp_Id+"Name "+Emp_Name;
    }
    #endregion
}
}