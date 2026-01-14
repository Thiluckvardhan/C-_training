namespace Day16
{
    public class LinqStudent
    {
        public string Name{get;set;}
    }

    public class Process //Process class to store all system processes
    {
        public int Id{get;set;}
        public string Name{get;set;}
    }
    public class LinqExample
    {
        public LinqExample()
        {
            string[] names = { "A", "B", "C", "ABA", "Abb" };

            //traditionally we use foreach which is slow in iterating
            // foreach (var item in names)
            // {
            //     if (item == "B")
            //     {
            //         Console.WriteLine("B is Present");
            //     }
            // }

            #region Linq
            // This is for finding elements
            // Console.WriteLine("----------------Finding Elements using Linq-----------------------");
            // var findName = from name in names where name == "B" select name;

            // if (findName != null)
            // {
            //     Console.WriteLine("Found name B");
            // }

            //Bulk/ Batch operations using Linq
            // var findNames = from name in names orderby name descending select name.ToLower();

            // Console.WriteLine("--------------------Batch Operation Example------------------------");
            // foreach (var name in findNames)
            // {
            //     Console.WriteLine(name);
            // }

            // Calling Methods using Linq

            // findNames = from name in names select IsPalindrome(name);
            // Console.WriteLine("--------------Calling Palindrome------------------");
            // foreach (var name in findNames)
            // {
            //     Console.WriteLine(name);
            // }

            //Creating objects of a class and storing 

            // var objects=from name in names orderby name ascending select new LinqStudent(){ Name=name};
            // Console.WriteLine("----------------------Objects creation and allocation--------------------");
            // foreach (var obj in objects)
            // {
            //     Console.WriteLine(obj); // this is used to show the linqstudent type 
            // }

            // creating system processes in order and storing in list of Process class reference


            // var processobjects=from p in System.Diagnostics.Process.GetProcesses() select new Process(){Id=p.Id, Name=p.ProcessName};

            // Console.WriteLine("-----------------creating system processes in order and storing in list of Process class reference------------------------");
            // foreach(var p in processobjects)
            // {
            //     Console.WriteLine($"{p.Name} - {p.Id}");
            // }
            #endregion

            #region region Dynamic Classes
            // Console.WriteLine("----------------------Dynamic classes--------------------------");

            // var dynamiclassobjects=from p in System.Diagnostics.Process.GetProcesses() select new {Id=p.Id, Name=p.ProcessName};

            // foreach(var p in dynamiclassobjects)
            // {
            //     Console.WriteLine($"{p.Name} - {p.Id}");
            // }

            #endregion
        }

        public string IsPalindrome(string name)
        {
            string output=new(name.Reverse().ToArray()); // when using reverse, it returns a char array in reverse 
            if (output== name)
            {
                return "Palindrome " + name;
            }
            return "Not Palindrome " + name;
        }
    }
}