namespace Day9
{
    /// <summary>
    /// Second part of the partial PartialClass.
    /// Defines the constructor and methods for the class.
    /// </summary>
    public partial class PartialClass
    {
        /// <summary>
        /// Constructor that initializes Id and Name properties.
        /// This demonstrates how partial classes can split functionality across files.
        /// </summary>
        /// <param name="id">The ID to initialize</param>
        /// <param name="name">The Name to initialize</param>
        public PartialClass(int id,string name)
        {
            this.Id=id;
            this.Name=name;
        }

        /// <summary>
        /// Displays the details (Id and Name) to the console.
        /// </summary>
        public void GetDetails()
        {
            System.Console.WriteLine(this.Id);
            System.Console.WriteLine(this.Name);
        }
    }
}