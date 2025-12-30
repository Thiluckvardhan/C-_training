namespace Day10
{
    public class Program
    {
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

            MyCollection myCollection= new MyCollection();

            myCollection.Add("Apple");
            myCollection.Add(2);
            myCollection.Clear();
        }
    }
}