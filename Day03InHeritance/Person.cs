using System;
using System.Diagnostics.Contracts;

namespace Day3
{
    /// <summary>
    /// Base class representing a person with name and age.
    /// </summary>
    public class Person
    {
        #region Fields
        // Person's name
        public String Name;
        // Person's age in years
        public int Age;
        #endregion

        #region Constructors
        /// <summary>
        /// Protected default constructor initializing fields to default values.
        /// </summary>
        protected Person()
        {
            Name=String.Empty;
            Age=0;
        }
        /// <summary>
        /// Initializes a new person with specified name and age.
        /// </summary>
        /// <param name="name">The person's name.</param>
        /// <param name="age">The person's age.</param>
        public Person(String name,int age)
        {
            Name=name;
            Age=age;
        }
        #endregion
    }

    /// <summary>
    /// Represents a male person with sports interests.
    /// </summary>
    public class Man : Person
    {
        #region Fields
        // Sports or activities the man plays
        public String plays;
        #endregion
    }

    /// <summary>
    /// Represents a female person with management responsibilities.
    /// </summary>
    public class Woman : Person
    {
        #region Fields
        // Activities or roles the woman manages
        public String PlayManage;
        #endregion
    }

    /// <summary>
    /// Provides utility methods for formatting person details.
    /// </summary>
    public static class PersonHelper
    {
        #region Methods
        /// <summary>
        /// Formats person details based on the derived type.
        /// </summary>
        /// <param name="person">The person object to format.</param>
        /// <returns>A formatted string with type-specific details.</returns>
        public static string GetDetails(Person person)
        {
            if (person is Man)
            {
                Man man=(Man) person;
                return $"Name {man.Name}, Age {man.Age}, Plays {man.plays}";
            }
            else if (person is Woman woman)
            {
                return $"Name {woman.Name}, Age {woman.Age}, Manages {woman.PlayManage}";
            }
            else
            {
                return $"Name {person.Name}, Age {person.Age}";
            }
        }
        #endregion
    }
}