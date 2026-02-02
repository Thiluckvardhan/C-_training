namespace EmployeeManagementSystem
{
    public class Employee
    {
        public int EmployeeId {get;set;}
        public string Name {get;set;}
        public string Department{ get;set;}
        public double Salary{get;set;}
        public DateTime JoiningDate{get;set;}
    }

    public class HRManager
    {
        public static SortedDictionary<int,Employee> employees=new();
        public void AddEmployee(string name, string dept, double salary)
        {
            
        }
    }
}