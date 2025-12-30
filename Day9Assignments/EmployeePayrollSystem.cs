namespace Day9Assignment
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected decimal Salary { get; }
        public abstract void CalcSalary(decimal salary);

        protected Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name) : base(id, name)
        {

        }
        public override void CalcSalary(decimal salary)
        {
            Console.WriteLine($"Full Time Employee Salary is {salary * 2m}");
        }
    }
    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name) : base(id, name)
        {

        }
        public override void CalcSalary(decimal salary)
        {
            System.Console.WriteLine($"Contract Employee Salary is {salary * 1.5m}");
        }
    }
}