
using System.Reflection;

public class Department
{
    private int id;
    public string val;
}

public class Program
{
    public static void Main(string[] args)
    {
        Department obj=new Department();

        var props=obj.GetType().GetFields(BindingFlags.NonPublic|BindingFlags.Instance).ToList();  //This will show the private fileds only
        foreach(var prop in props)
        {
            Console.WriteLine(prop.Name);
        }

    }
}