namespace Day9Assignment
{
    public abstract class Payment
    {
        public abstract void ProcessPayment();
    }
    public class CreditCard:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Payment using Credit Card");
        }
    }
    public class UPI:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Payment using UPI");
        }
    }
    public class NetBanking:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing Payment using Net Banking");
        }
    }
}