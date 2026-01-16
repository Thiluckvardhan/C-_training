namespace Day18
{
    /// <summary>Represents a shopper with wallet balance and purchase totals.</summary>
    public class EcommerceShop
    {
        public string? UserName { get; set; }
        public double WalletBalance { get; set; }
        public double TotalPurchaseAmount { get; set; }
    }

    /// <summary>Processes wallet payments for purchases and signals insufficient funds.</summary>
    public class Question5
    {
        public EcommerceShop Makepayment(string name,double balance,double amount)
        {
            if (balance < amount)
            {
                // Stop payment when wallet cannot cover the charge
                throw new InsufficientWalletBalanceException();
            }

            // Create a snapshot of the successful payment
            EcommerceShop es=new EcommerceShop
            {
              UserName=name,
              WalletBalance=balance,
              TotalPurchaseAmount=amount
            };
            return es;
        }

        /// <summary>Raised when a digital wallet lacks the funds needed for payment.</summary>
        public class InsufficientWalletBalanceException : Exception
        {
            public InsufficientWalletBalanceException():base("Insufficient balance in your digital wallet.")
            {
                
            }
        }
    }
}