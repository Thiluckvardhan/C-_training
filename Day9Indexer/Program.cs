namespace Day9
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyData mydata = new MyData();
            mydata[0] = "C";
            mydata[1] = "C++";
            mydata[2] = "c#";

            Console.WriteLine(mydata[0]);
            Console.WriteLine(mydata[1]);
            Console.WriteLine(mydata[2]);
        }
    }
}