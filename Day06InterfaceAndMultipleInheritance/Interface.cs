namespace Day6
{
    #region Interface
    /// <summary>
    /// This is an Example of Interface
    /// </summary>
    interface Intter
    {
        public void PrintName(String name);

    }
    #endregion
    /// <summary>
    /// This inherits the interface 
    /// </summary>
    public class Printer : Intter
    {
        public void PrintName(String name)
        {
            Console.WriteLine("My name is " + name);
        }
    }

}