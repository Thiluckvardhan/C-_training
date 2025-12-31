namespace Day10
{
    /// <summary>
    /// Main program to demonstrate regex patterns, garbage collection, and custom collections.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point demonstrating various Day10 concepts.
        /// - RegexTimeout: Pattern matching with timeout
        /// - GarbageCollector: Memory management and GC behavior
        /// - DistructorExample: IDisposable pattern
        /// - MyCollection: Custom collection implementation
        /// </summary>
        public static void Main(string[] args)
        {
            // RegexTimeout regex=new RegexTimeout();
            // regex.Check();

            // GarbageCollector garbageCollector=new GarbageCollector();
            // garbageCollector.Example();

            //try
            //{
            //    DistructorExample de=new DistructorExample();
            //    de.List.Add(1);
            //    de.Lsit.Add(2);

            //}
            //catch
            //{
                
            //}
            //finally
            //{
            //    de.Dispose();
            //}

            // Demonstrate custom collection implementation
            MyCollection myCollection= new MyCollection();

            // Add mixed types to the collection
            myCollection.Add("Apple");
            myCollection.Add(2);
            
            // Clear all items from the collection
            myCollection.Clear();
        }
    }
}