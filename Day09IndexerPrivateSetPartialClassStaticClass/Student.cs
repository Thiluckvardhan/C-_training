using System.Collections.Generic;
namespace Day9

{
    /// <summary>
    /// Student class that demonstrates indexer functionality.
    /// Allows storing and retrieving books associated with a student.
    /// </summary>
    public class Student
    {
        // Gets or sets the student's roll number.
        public int RollNo{get;set;}
        
        // Gets or sets the student's name.
        public string Name{get;set;}
        
        // Stores the student's address.
        private string Address;
        
        // List to store books associated with the student.
        private List<string> Books=new List<string>();

        /// <summary>
        /// Indexer to access books by index.
        /// Allows reading and adding books using array notation.
        /// </summary>
        /// <param name="index">The index of the book</param>
        /// <returns>The book title at the specified index</returns>
        public string this[int index]
        {
            get
            {
                if (index >= Books.Count)
                {
                    return "Index is not Correct.";
                }
                return Books[index];
            }
            set
            {
                if (index < Books.Count)
                {
                    Books[index]=value;
                }
                Books.Add(value);
            }
        }
        
        /// <summary>
        /// Constructor to initialize student details.
        /// </summary>
        /// <param name="rollno">The student's roll number</param>
        /// <param name="name">The student's name</param>
        /// <param name="address">The student's address</param>
        public Student(int rollno,string name,string address)
        {
            this.RollNo=rollno;
            this.Name=name;
            this.Address=address;
        }
    }
}