namespace ExamSchedular.Model
{
    /// <summary>
    /// Represents a section or batch in the exam scheduling system.
    /// Each section represents a group of students for exam organization.
    /// </summary>
    public class Section
    {
        /// <summary>
        /// Default constructor for the Section class.
        /// </summary>
        public Section()
        {

        }
        
        /// <summary>
        /// Gets or sets the unique identifier for the section/batch.
        /// Format typically follows pattern like "CSE2025Batch1".
        /// </summary>
        public string Id { get; set; }
    }
}