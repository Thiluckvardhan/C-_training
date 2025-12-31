namespace ExamSchedular.Model
{
    /// <summary>
    /// Represents a section that contains multiple students.
    /// Used to group students together for exam scheduling purposes.
    /// </summary>
    public class StudentsSection
    {
        /// <summary>
        /// Default constructor for the StudentsSection class.
        /// </summary>
        public StudentsSection()
        {

        }
        
        /// <summary>
        /// List to store all students in this section.
        /// </summary>
        List<Student> students = new List<Student>();
    }
}