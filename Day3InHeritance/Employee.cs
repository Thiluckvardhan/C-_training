namespace Day3
{
    public class Employee
{
    int Emp_Id;
    String Emp_Name;
    

    public Employee()
    {
        Emp_Id=0;
        Emp_Name=String.Empty;
    }

    public String GetDetails()
    {
        return "Id "+Emp_Id+"Name "+Emp_Name;
    }
}
}