using System;

namespace Day4
{
    /// <summary>
    /// Explains the concept of virtual and override 
    /// </summary>
    
    #region Override example
    /// <summary>
    /// Base class demonstrating virtual method usage.
    /// </summary>
    public class Father
    {
        #region Methods
        /// <summary>
        /// Returns the father's interest, can be overridden by derived classes.
        /// </summary>
        /// <returns>Interest description string.</returns>
        public virtual string InterestOn()
        {
            return "I Like to play Cricket";
        }
        #endregion
    }
    /// <summary>
    /// Derived class demonstrating method override.
    /// </summary>
    public class Son : Father
    {
        #region Methods
        /// <summary>
        /// Overrides the base interest with the son's preference.
        /// </summary>
        /// <returns>Son's interest description string.</returns>
        public override string InterestOn()
        {
            return "Mobile Games";
        }
        #endregion
    }
    #endregion
}