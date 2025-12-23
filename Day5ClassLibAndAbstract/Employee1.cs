namespace Day5
{
    public abstract class Employee1
    {
        public abstract void CalcTax();
    }
    public class IndianEmployee:Employee1
    {
        public override void CalcTax()
        {
            Console.WriteLine("IndianEmployee Tax is Calculated");
        }
    }
    public class USEmployee : Employee1
    {
        public override void CalcTax()
        {
            Console.WriteLine("USEmployee Tax is Calculated");
        }
    }
}