namespace Day9
{
    /// <summary>
    /// Static class that stores static data and provides static methods.
    /// Demonstrates static initialization and static data storage.
    /// </summary>
    public static class GeneralUsers
    {
        // Static field to store the roll number.
        static int RollNo;
        
        /// <summary>
        /// Static constructor that initializes the RollNo.
        /// Runs once when the class is first accessed.
        /// </summary>
        static GeneralUsers(){
            RollNo=22;
        }
        
        /// <summary>
        /// Gets and displays the static roll number to the console.
        /// </summary>
        public static void GetRollNo()
        {
            System.Console.WriteLine(RollNo);
        }
    }
}