namespace Question2
{
    public class Source
    {
        public int Add(int a,int b,int c)
        {
            return a+b+c;
        }

        public double Add(double a,double b,double c)
        {
            return a+b+c;
        }
    }
}

// Question 2: Method Overloading

// Problem Statement:
// Method Overloading is a common way of implementing polymorphism. C# can distinguish methods with different method signatures.

// Specifications

// Class: Source

// Add(int a, int b, int c)

// Adds three integers

// Return type: int

// Add(double a, double b, double c)

// Adds three doubles

// Return type: double

// Task

// Create a class Source and demonstrate function overloading by changing the data types of parameters.