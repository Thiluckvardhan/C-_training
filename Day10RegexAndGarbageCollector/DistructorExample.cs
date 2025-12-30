namespace Day10
{
    public class DistructorExample:IDisposable
    {
        List<int> list=[];

        public void Dispose()
        {
            List.Clear();
            List = null;
        }
    }
}