namespace Practise
{
    public class BankAccount
    {
        public int AccountNumber{get;set;}
        public string Name{get;set;}
        protected decimal Balance{get;set;}

        public BankAccount(int id,string name)
        {
            this.AccountNumber=id;
            this.Name=name;
        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit Amount Should be Greater than 0\n");
            }
            else
            {
                Balance+=amount;
                Console.WriteLine("**********Balance Updated**********\n");
                Console.WriteLine($"Updated Balance: {Balance}\n");
            }

        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw Amount should be Greater than 0\n");
            }
            else if (Balance == 0)
            {
                Console.WriteLine("Withdraw not possible Account Balance is zero.\n");
            }
            else
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Withdraw not possilbe as Bank Balance is less than Withdraw Amount\n");
                }
                else
                {
                    Balance-=amount;
                    Console.WriteLine("******************Withdraw Successful**************\n");
                    Console.WriteLine($"Balance Amount: {Balance}\n");
                }
            }
        }

    }
}