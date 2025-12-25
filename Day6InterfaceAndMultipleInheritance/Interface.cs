namespace Day6
{
    interface Intter
    {
        public void PrintName(String name);

    }
    public class Printer : Intter
    {
        public void PrintName(String name)
        {
            Console.WriteLine("My name is " + name);
        }
    }
}