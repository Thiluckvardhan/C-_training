namespace DigitalWallet.Core
{
    public class WalletData
    {
        //value Types
        public int UsedId;
        public decimal Balance;
        public bool isActive;

        //Reference
        public string UserName;

        //Array to store in transactions
        public decimal[] RecentTransactions;
    }
}