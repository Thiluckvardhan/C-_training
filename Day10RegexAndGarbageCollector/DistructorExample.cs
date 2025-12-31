using System.Collections.Generic;
namespace Day10
{
    /// <summary>
    /// Demonstrates the IDisposable pattern for proper resource cleanup.
    /// Shows how to implement proper disposal methods for managed resources.
    /// </summary>
    public class DistructorExample:IDisposable
    {
        // Internal list to store integer values.
        List<int> list=new List<int>();

        /// <summary>
        /// Disposes of the resources held by this object.
        /// Clears the list and releases the reference to allow garbage collection.
        /// </summary>
        public void Dispose()
        {
            list.Clear();
            list = null;
        }
    }
}