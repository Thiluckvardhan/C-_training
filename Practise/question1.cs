namespace Question1
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    public class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string result = "";
            foreach (var p in person)
            {
                result += p.Name + " ";
                result += p.Address + " ";
            }
            return result;
        }
        public double Average(IList<Person> person)
        {
            double result = 0.0;
            double count = 0;
            foreach (var p in person)
            {
                result += p.Age;
                count++;
            }
            return result / count;
        }
        public int Max(IList<Person> person)
        {
            int result = int.MinValue;
            foreach (var p in person)
            {
                int age = p.Age;
                if (age > result)
                {
                    result = age;
                }
            }
            return result;
        }
    }
}

// Question 1: Person Details (C# – OOPS & Collections)

// Problem Statement:
// Your task here is to implement a C# code based on the following specifications. Note that your code should match the specifications in a precise manner. Consider default visibility of classes, data fields, and methods unless mentioned otherwise.

// Specifications
// Class Definitions

// Class: Person

// Properties (Auto-implemented):

// Name : string (public)

// Address : string (public)

// Age : int (public)

// Class: PersonImplementation

// GetName(IList<Person> person)

// Display the name and address of all persons in the list

// Return type: string

// Visibility: public

// Average(IList<Person> person)

// Calculate the average age

// Return type: double

// Visibility: public

// Max(IList<Person> person)

// Calculate the maximum age

// Return type: int

// Visibility: public