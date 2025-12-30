namespace Day6
{
    public class ExamSchedular :ISemester,IExaminer
    {
        public ExamSchedular()
        {
            Console.WriteLine(SemId, " ", UserId);
        }
    }
}