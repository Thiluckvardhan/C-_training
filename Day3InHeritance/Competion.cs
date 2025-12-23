using System;

namespace Day3
{
    /// <summary>
    /// Represents a competition with identifier and name.
    /// </summary>
    public class Competion{
    #region Fields
    // Competition identifier
    int Com_Id;
    // Competition name
    String Com_Name;
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance with default values.
    /// </summary>
    public Competion()
    {
        Com_Id=0;
        Com_Name=String.Empty;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Returns a formatted string containing competition details.
    /// </summary>
    /// <returns>Competition ID and name as a string.</returns>
    public String GetDetails()
    {
        return "Id "+Com_Id+"Name "+Com_Name;
    }
    #endregion
}
}