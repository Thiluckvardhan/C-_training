using System.Diagnostics.Contracts;

namespace Day3
{
    public class Person
    {
        public String Name;
        public int Age;
        protected Person()
        {
            Name=String.Empty;
            Age=0;
        }
        public Person(String name,int age)
        {
            Name=name;
            Age=age;
        }
    }

    public class Man : Person
    {
        public String plays;
    }

    public class Woman : Person
    {
        public String PlayManage;
    }

    public static class PersonHelper
    {
        public static string GetDetails(Person person)
        {
            if (person is Man)
            {
                Man man=(Man) person;
                return $"Name {man.Name}, Age {man.Age}, Plays {man.plays}";
            }
            else if (person is Woman woman)
            {
                return $"Name {woman.Name}, Age {woman.Age}, Manages {woman.PlayManage}";
            }
            else
            {
                return $"Name {person.Name}, Age {person.Age}";
            }
        }
    }
}