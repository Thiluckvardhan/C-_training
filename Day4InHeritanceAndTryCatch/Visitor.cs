using System;

namespace Day4
{
    /// <summary>
    /// Represents a visitor with chained constructors and validation.
    /// Maintains a log history of object creation steps.
    /// </summary>
    public class Visitor
    {
        #region Properties
        // Visitor identifier
        public int Id {get;set;}
        // Visitor name
        public string Name{get;set;}
        // Visitor's requirement or purpose
        public string Requirement{get;set;}
        // Log of creation timestamps
        public string logHistroy{get;set;}
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor that initializes the log history.
        /// </summary>
        public  Visitor()
        {
            logHistroy=$"Object created on {DateTime.Now.ToString()} \n";
        }

        /// <summary>
        /// Constructor that sets the visitor ID and chains to the default constructor.
        /// </summary>
        /// <param name="id">The visitor's unique identifier.</param>
        public Visitor(int id):this()
        {
            this.Id=id;
            logHistroy=$"Id created on {DateTime.Now.ToString()} \n";
        }
        /// <summary>
        /// Constructor that sets ID and name with validation for inappropriate content.
        /// </summary>
        /// <param name="id">The visitor's unique identifier.</param>
        /// <param name="name">The visitor's name.</param>
        /// <exception cref="ArgumentException">Thrown when name contains inappropriate words.</exception>
        public Visitor(int id,string name):this(id)
        {
            if(name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("Name contains inappropriate content.");
            }
            logHistroy=$"Name created on {DateTime.Now.ToString()} \n";
            this.Name=name;
        }
        /// <summary>
        /// Constructor that sets ID, name, and requirement.
        /// </summary>
        /// <param name="id">The visitor's unique identifier.</param>
        /// <param name="name">The visitor's name.</param>
        /// <param name="requirement">The visitor's requirement or purpose.</param>
        public Visitor(int id,string name,string requirement):this(id,name)
        {
            this.Requirement=requirement;
            logHistroy=$"Requirement created on {DateTime.Now.ToString()} \n";
        }
        #endregion
    }
}