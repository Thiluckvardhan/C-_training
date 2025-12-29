using ExamSchedular.Model;
namespace ExamSchedular.Data
{
    public static class DataBank
    {
        static List<Student> students=new List<Student>();
        static DataBank(){
            students.Add(new Student() {Id=1,Name="Thiluck"});
            students.Add(new Student() {Id=2,Name="Divyansh"});
            students.Add(new Student() {Id=3,Name="Harsha"});
            students.Add(new Student() {Id=4,Name="Sumanth"});
        }
        
        public static List<Student> GetStudentsData()
        {
            return students;
        }
    }
}