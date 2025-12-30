namespace Day4
{
    /// <summary>
    /// Base account containing shared identity and details logic for derived account types.
    /// </summary>
    public class Account
    {
        #region Properties
        public string Name { get; set; }
        public int AccountId { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a simple description of the base account including its identifier.
        /// </summary>
        public string GetAccountDetails()
        {
            return $"I am Base account . My Id is {AccountId}";
        }
        #endregion
    }

    /// <summary>
    /// Represents a sales account with additional sales-specific information.
    /// </summary>
    public class SalesAccount : Account 
    {
        #region Properties
        public string SalesInfo { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Builds a combined description including base account details and sales-specific context.
        /// </summary>
        public string GetSalesAccountDetails()
        {
            string info = string.Empty;
            info += base.GetAccountDetails();
            info += "I am from Sales Derived class ";
            return info;
        }
        #endregion
    }

    /// <summary>
    /// Represents a purchase account with additional purchase-specific information.
    /// </summary>
    public class PurchaseAccount : Account
    {
        #region Properties
        public string PurchaseInfo { get; set; }
        #endregion
    }
}