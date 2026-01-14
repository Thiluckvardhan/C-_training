namespace Day16
{
    public class Student(string name, double marks1, double marks2)
    {
        public string Name { get; set; } = name;
        public double Marks1 { get; set; } = marks1;
        public double Marks2 { get; set; } = marks2;
    }

    public class LambdaClass
    {
        public void DisplayMaxAverage(List<Student> students)
        {
            var maxAverage = students.Max(s => (s.Marks1 + s.Marks2) / 2); //Using lambda 

            maxAverage =(from s in students select (s.Marks1 + s.Marks2) / 2).Max();

            Console.WriteLine($"Max Average: {maxAverage}");

        }
    }
}



