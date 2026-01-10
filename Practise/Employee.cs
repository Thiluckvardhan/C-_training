public class Employee
{
    public string Name {get;set;}
    public int Id{get;set;}
    public double Salary{get;set;}

    public Employee(string name,int id,double salary)
    {
        this.Name=name;
        this.Id=id;
        this.Salary=salary;

        Console.WriteLine($"Employee Name {this.Name}");
        Console.WriteLine($"Employee Id {this.Id}");
        Console.WriteLine($"Employee Salary {this.Salary}");
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Employee emp1=new Employee("Thiluck",1,2000.5);
//     }
// }