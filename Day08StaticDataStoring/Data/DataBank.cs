using ExamSchedular.Model;
namespace ExamSchedular.Data
{
    /// <summary>
    /// Static class that stores and manages student data.
    /// Uses static constructor to initialize student data.
    /// </summary>
    public static class DataBank
    {
        /// <summary>
        /// Static list to store all student records in memory.
        /// </summary>
        static List<Student> students=new List<Student>();
        
        /// <summary>
        /// Static constructor runs once when the class is first accessed.
        /// Initializes the student list with predefined data.
        /// </summary>
        static DataBank(){
            students.Add(new Student() {Id=1,Name="Thiluck"});
            students.Add(new Student() {Id=2,Name="Divyansh"});
            students.Add(new Student() {Id=3,Name="Harsha"});
            students.Add(new Student() {Id=4,Name="Sumanth"});
        }
        
        /// <summary>
        /// Retrieves all student data from the static list.
        /// </summary>
        /// <returns>List of all students</returns>
        public static List<Student> GetStudentsData()
        {
            return students;
        }
    }
}