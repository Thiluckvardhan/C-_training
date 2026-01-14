using System.IO;
namespace Day17
{
    public class FileHandlingExample
    {
        public void Example1()
        {
            string[] lines = { "First line", "Second line", "Third line" };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, "test.txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                outputFile.WriteLine(line);
            }
        }
    }
}