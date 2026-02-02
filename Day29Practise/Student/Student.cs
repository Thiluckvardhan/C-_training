namespace StudentPractise
{
    public delegate string Notify();
    public class Student : IComparable<Student>
    {
        public string Name{get;set;}
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public double average { get; set; }
        public event Notify notify;
        public Student(string name,int marks1, int marks2)
        {
            Name=name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            average = Math.Round((marks1 + marks2) / 2.0, 2);
        }
        public int CompareTo(Student other)
        {
            return other.average.CompareTo(this.average);
        }
        public string Result()
        {
            if (average < 40) notify=NeedImprovement;
            else if(average<80) notify=GoodStudent;
            else notify=BrillientSudent;
            return notify?.Invoke();
        }
        public string NeedImprovement()
        {
            return "Need Improvemnt";
        }
        public string GoodStudent()
        {
            return "Good Student";
        }
        public string BrillientSudent()
        {
            return "Brillient Studnet";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Student student1 = new Student("Thiluck",65, 70);
            Student student2 = new Student("Divyansh",20, 30);
            Student student3 = new Student("Vishwajeet",90, 85);
            List<Student> students = new List<Student>
            {
                student1,student2,student3
            };
            students.Sort();
            int rank=1;
            foreach (var student in students)
            {
                System.Console.Write($"Rank = {rank++} Name = {student.Name} average = {student.average} ");
                System.Console.WriteLine(student.Result());
            }
        }
    }
}