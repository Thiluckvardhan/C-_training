namespace Day9Assignment{
public class Program
{
    public static void Main(string[] args)
    {
        #region Encapsulation Example
        // BankAccount account1=new BankAccount(22,"Thiluck");

        // account1.Withdraw(2000);
        // account1.Deposit(10000);
        // account1.Withdraw(2000000);
        // account1.Withdraw(2000);
        // account1.Deposit(-100);
        // account1.Withdraw(-20);
        #endregion

        #region Inheritance using Abstract class
        // FullTimeEmployee fulltimeemp=new FullTimeEmployee(1,"Thiluck");
        // fulltimeemp.CalcSalary(5000);
        // ContractEmployee contractemployee=new ContractEmployee(2,"Aarjav");
        // contractemployee.CalcSalary(5000);
        #endregion

        #region Polymorphism and Abstraction
        // Payment creditcard=new CreditCard();
        // creditcard.ProcessPayment();
        // Payment upi=new UPI();
        // upi.ProcessPayment();
        // Payment netbanking=new NetBanking();
        // netbanking.ProcessPayment();
        #endregion

        #region Interface Example with notification type
        // var whatsapp=new NotificationService(new WhatsApp());
        // whatsapp.Notify("Hello From Thiluck");
        #endregion

        #region Method OverLoading Example
        BillingSystem billingSystem= new BillingSystem();
        billingSystem.CalcBill(2000,28,500);
        billingSystem.CalcBill(2000.00,14.5,500);
        #endregion

        #region Method OverRiding Example
        Insurance insurance=new HealthInsurance();
        insurance.CalcInsurance(5000);
        insurance=new LifeInsurance();
        insurance.CalcInsurance(5000);
        #endregion
    }
}
}