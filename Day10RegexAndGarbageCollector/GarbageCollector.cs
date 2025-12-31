using System.Collections.Generic;
namespace Day10
{
    /// <summary>
    /// Demonstrates garbage collection behavior and memory management in .NET.
    /// Shows how to monitor memory allocation and deallocation.
    /// </summary>
    public class GarbageCollector
    {
        /// <summary>
        /// Example method that demonstrates memory allocation and garbage collection.
        /// Creates many byte arrays and monitors memory usage before and after.
        /// </summary>
        public void Example()
        {
            // Create a list to hold multiple byte arrays
            var list=new List<byte[]>();
            
            // Allocate memory for 20000 byte arrays (1KB each)
            for(int i = 0; i < 20000; i++)
            {
                list.Add(new byte[1024]);//many allocations
            }

            // Display memory usage after allocation
            Console.WriteLine("Allocated");
            Console.WriteLine("Total Memory: "+GC.GetTotalMemory(forceFullCollection: false));
            
            // Release reference to the list (objects become eligible for garbage collection)
            list=null;
            
            // Optionally force garbage collection with: GC.Collect()
            // Console.WriteLine("Total Memory: "+GC.GetTotalMemory(forceFullCollection: true));
            Console.WriteLine("Total Memory: "+GC.GetTotalMemory(forceFullCollection: false));
        }
    }
}