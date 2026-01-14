namespace Day16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Linq Example
                LinqExample linqexample=new();
            #endregion

            var students = new List<Student>
            {
                new("Alice", 80, 90),
                new("Bob", 85, 95),
                new("Charlie", 70, 75)
            };

            LambdaClass lm=new();
            lm.DisplayMaxAverage(students);

            //Generics with Linq
            LearnLinq.RunDemo();
        }
    }
}