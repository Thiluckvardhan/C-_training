using ExamSchedular.Model;
namespace ExamSchedular.Data
{
    /// <summary>
    /// Static class that stores and manages section data.
    /// Provides access to predefined section/batch information.
    /// </summary>
    public class DataSection
    {
        /// <summary>
        /// Static list to store all section records in memory.
        /// </summary>
        static List<Section> section = new List<Section>();
        
        /// <summary>
        /// Static constructor runs once when the class is first accessed.
        /// Initializes the section list with batch data.
        /// </summary>
        static DataSection(){
            section.Add(new Section() {Id="CSE2025Batch1"});
            section.Add(new Section() {Id="CSE2025Batch2"});
            section.Add(new Section() {Id="CSE2025Batch3"});
        }

        /// <summary>
        /// Retrieves all section details from the static list.
        /// </summary>
        /// <returns>List of all sections/batches</returns>
        public static List<Section> GetSectionDetails()
        {
            return section;
        }
    }
}