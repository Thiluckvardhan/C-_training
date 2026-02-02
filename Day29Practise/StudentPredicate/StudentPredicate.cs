namespace StudentPractise
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int marks1 { get; set; }
        public int marks2 { get; set; }
        public double average { get; set; }
        public Student(string name, int marks1, int marks2)
        {
            Name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
        }
        public int CompareTo(Student other)
        {
            return other.average.CompareTo(this.average);
        }
        public Predicate<double> IsPass = marks => marks > 40;
    }

    public class Program
    {
        public Func<Student, double> Average = student =>
            {
                student.average = student.marks1 + student.marks2 / 2.0;
                return student.average;
            };
        public Action<Student, int> PrintDetails = (student, rank) =>
              {
                    Program p= new();
                    System.Console.Write($"Rank = {rank++} Name = {student.Name} average = {p.Average(student)} ");
                    System.Console.WriteLine(student.IsPass(student.average) ? "Passed " : "Failed");
              };
        public static void Main()
        {
            Student student1 = new Student("Thiluck", 65, 70);
            Student student2 = new Student("Divyansh", 20, 30);
            Student student3 = new Student("Vishwajeet", 90, 85);
            List<Student> students = new List<Student>
            {
                student1,student2,student3
            };


            students.Sort();
            int rank = 1;
            Program p=new();
            foreach (var student in students)
            {
                p.PrintDetails(student, rank++);
            }
        }
    }
}