namespace Day9Assignment
{
    public class BillingSystem
    {
        public void CalcBill(int amount, int tax, int discount)
        {
            double total = (amount - discount) / 100 * tax;
            Console.WriteLine($"Your Total is {total}");
        }
        public void CalcBill(double amount, double tax, double discount)
        {
            double total = (amount - discount) / 100 * tax;
            Console.WriteLine($"Your Total is {total}");
        }
    }
}