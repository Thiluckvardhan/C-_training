namespace Day22
{
    public class ObsoleteAttributeExample
    {
        [Obsolete("Use the Add(int a,int b) method instead")]
        public int OldAdd(int a,int b)
        {
            return a+b;
        }

        public int Add(int a,int b)
        {
            return a+b;
        }
    }

}