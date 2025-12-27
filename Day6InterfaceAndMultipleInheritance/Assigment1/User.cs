using System.Runtime.CompilerServices;

namespace Day6
{
    public class User
    {
        protected int UserId { get; set; }
        protected string UserName { get; set; }
        protected string UserDesignation { get; set; }
        protected string UserRole { get; set; }
        protected User(int id)
        {
            this.UserId=id;
        }
        protected User(int id,string name):this(id)
        {
            this.UserName=name;
        }
        protected User(int id, string name, string designation):this(id,name)
        {
            this.UserDesignation = designation;
        }
        protected User(int id, string name, string designation, string role) : this(id, name, designation)
        {
            this.UserRole=role;
        }
    }

    public class Employee:User
    {
        public Employee(int id,string name) : base(id, name)
        {
            this.UserRole="Employee";
        }   
    }
    public class HOD : Employee
    {
        public HOD(int id,string name):base(id,name)
        {
            this.UserDesignation="HOD";
        }
    }
    public class Examiner : Employee
    {
        public Examiner(int id,string name) : base(id, name)
        {
            this.UserDesignation = "Examiner";
        }
    }

    public class Student : User
    {
        public Student(int id,string name) : base(id, name)
        {
            this.UserRole = "Student";
            this.UserDesignation = "Student";
        }
    }
}