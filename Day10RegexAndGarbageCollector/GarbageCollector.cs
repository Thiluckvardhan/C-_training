using System.Collections.Generic;
namespace Day10
{
    public class GarbageCollector
    {
        public void Example()
        {
            var list=new List<byte[]>();
            for(int i = 0; i < 20000; i++)
            {
                list.Add(new byte[1024]);//many allocations
            }

            Console.WriteLine("Allocated");
            Console.WriteLine("Total Memory: "+GC.GetTotalMemory(forceFullCollection: false));
            list=null;
            // GC.Collect()
            Console.WriteLine("Total Memory: "+GC.GetTotalMemory(forceFullCollection: false));


        }
    }
}