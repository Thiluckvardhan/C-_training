using ExamSchedular.Model;
namespace ExamSchedular.Data
{
    public class DataSection
    {
        static List<Section> section = new List<Section>();
        static DataSection(){
            section.Add(new Section() {Id="CSE2025Batch1"});
            section.Add(new Section() {Id="CSE2025Batch2"});
            section.Add(new Section() {Id="CSE2025Batch3"});
        }

        public static List<Section> GetSectionDetails()
        {
            return section;
        }
    }
}