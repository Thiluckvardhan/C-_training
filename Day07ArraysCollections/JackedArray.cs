namespace Day7
{
    /// <summary>
    /// Demonstrates the use of jagged arrays in C#.
    /// A jagged array is an array of arrays where each row can have a different number of columns.
    /// </summary>
    public class JackedArray
    {
        public void Call()
        {
            // Declare a jagged array: an array of 3 rows, each row can have different length
            int[][] data = new int[3][];
            
            // Initialize each row with different number of elements
            data[0] = new int[] { 1, 2, 3 };        // Row 0: 3 elements
            data[1] = new int[] { 10, 20 };         // Row 1: 2 elements
            data[2] = new int[] { 7, 8, 9, 10 };    // Row 2: 4 elements

            // Iterate through each row in the jagged array
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                
                // Iterate through each element in the current row
                foreach (var v in data[i]) Console.Write(v + " ");
                
                Console.WriteLine();
            }
        }
    }
}