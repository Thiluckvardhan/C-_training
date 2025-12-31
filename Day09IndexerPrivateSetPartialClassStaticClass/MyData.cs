namespace Day9
{
    /// <summary>
    /// Demonstrates the use of indexers in C#.
    /// Allows objects to be accessed like arrays using index notation.
    /// </summary>
    public class MyData
    {
        // Internal array to store string data.
        private string[] arr = new string[10];

        /// <summary>
        /// Indexer to access and modify string values at specific indices.
        /// </summary>
        /// <param name="index">The array index to access</param>
        /// <returns>The string value at the specified index</returns>
        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}