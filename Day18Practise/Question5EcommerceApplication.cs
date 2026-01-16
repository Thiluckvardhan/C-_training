namespace Day18
{
    public class EcommerceShop
    {
        public string UserName { get; set; }
        public double WalletBalance { get; set; }
        public double TotalPurchaseAmount { get; set; }
    }

    public class Question5
    {
        public EcommerceShop Makepayment(string name,double balance,double amount)
        {
            if (balance < amount)
            {
                throw new InsufficientWalletBalanceException();
            }

            EcommerceShop es=new EcommerceShop
            {
              UserName=name,
              WalletBalance=balance,
              TotalPurchaseAmount=amount
            };
            return es;
        }

        public class InsufficientWalletBalanceException : Exception
        {
            public InsufficientWalletBalanceException():base("Insufficient balance in your digital wallet.")
            {
                
            }
        }
    }
}