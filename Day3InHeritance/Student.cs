namespace Day3
{
    public class Student
    {
        public int Id;
        public String Name;

        public Student()
        {
            Id = 0;
            Name = String.Empty;
        }

        public String GetDetails()
        {
            return "Id " + Id + "Name " + Name;
        }
    }
}
