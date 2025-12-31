namespace ExamSchedular.Model
{
    /// <summary>
    /// Represents a student in the exam scheduling system.
    /// Contains basic student information like ID and name.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Default constructor for the Student class.
        /// </summary>
        public Student()
        {
            
        }
        
        /// <summary>
        /// Gets or sets the unique identifier for the student.
        /// </summary>
        public int Id{get;set;}
        
        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string Name{get;set;}
    }
}