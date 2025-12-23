namespace Day4
{
    public class Emp
    {
        private int Id;
        private int Salary;
        private String Name;
        string throw_exception;
        // public int id
        // {
        //     set
        //     {
        //         if (value > 0) Id = value;
        //         else
        //         {
        //             Id = 0;
        //             throw new InvalidOperationException("Id must be greater than 0");
        //         }
        //     }
        // }

        public Emp(int id, String name, int salary)
        {
            if (id < 0)
            {
                throw_exception = "Id is invalid ";
            }
            if (string.IsNullOrEmpty(name))
            {
                throw_exception += " Name should not be Null";
            }
            if (salary < 0)
            {
                throw_exception += " Salary Should not be Negative";
            }
            if (!string.IsNullOrEmpty(throw_exception))
            {
                throw new ArgumentException(throw_exception);
            }
            else
            {
                this.Id = id;
                this.Name = name;
                this.Salary = salary;
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Id is {Id} Name {Name} Salary {Salary}");
        }
    }
}