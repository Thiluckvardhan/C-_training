using System;
using Day3;

/// <summary>
/// Entry point for Day3 inheritance examples demonstrating Person, Man, and Woman classes.
/// </summary>
class Program
{
    /// <summary>
    /// Application entry point. Creates instances and displays details using PersonHelper.
    /// </summary>
    static void Main()
    {
        #region Method Logic
        // DAY3
        // Student s1=new Student()
        // {
        //     Id=1,
        //     Name="Thiluck"
        // };
        // Student s2=new Student();


        Person person=new Person("Thiluck",20);
        Man man=new Man()
        {
            Name="Divyansh",
            Age=20,
            plays="Cricket"
        };
        Person woman=new Woman()
        {
            Name="Sundari",
            Age=19,
            PlayManage="Chess&Office"
        };
        Console.WriteLine(PersonHelper.GetDetails(person));
        Console.WriteLine(PersonHelper.GetDetails(man));
        Console.WriteLine(PersonHelper.GetDetails(woman));
        #endregion
    }
}

