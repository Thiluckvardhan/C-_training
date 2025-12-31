using System.Collections.Generic;
namespace Day10
{
    public class DistructorExample:IDisposable
    {
        List<int> list=new List<int>();

        public void Dispose()
        {
            list.Clear();
            list = null;
        }
    }
}