namespace Day9Assignment
{
    public class Insurance
    {
        public virtual void CalcInsurance(double amount)
        {
            Console.WriteLine("Call for specific Type of Insurance");
        }
    }

    public class HealthInsurance : Insurance
    {
        public override void CalcInsurance(double amount)
        {
            Console.WriteLine($"Health insurance is :{amount-amount*20/100}");
        }
    }

    public class LifeInsurance : Insurance
    {
        public override void CalcInsurance(double amount)
        {
            Console.WriteLine($"Life Insurance is: {amount-amount*10/100}");
        }
    }
}