using System;
namespace Day9
{
    /// <summary>
    /// Main entry point for the Day9 Indexer application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Demonstrates various C# features: indexers, partial classes, static classes, and string extensions.
        /// </summary>
        static void Main(string[] args)
        {

            #region Indexer Examples

            // example 1

            // MyData mydata = new MyData();
            // mydata[0] = "C";
            // mydata[1] = "C++";
            // mydata[2] = "c#";

            // Console.WriteLine(mydata[0]);
            // Console.WriteLine(mydata[1]);
            // Console.WriteLine(mydata[2]);

            // example 2

            // Student stu1=new Student(1,"Thiluck","Telangana");
            // stu1[0]="Game of Thrones";
            // stu1[1]="Harry Potter";

            // System.Console.WriteLine(stu1[0]);
            // System.Console.WriteLine(stu1[1]);
            #endregion

            #region Private Set Example
            // Console.WriteLine("Hello, World!");
            // YoungProfessional yp = new YoungProfessional();

            #endregion

            #region Partial Class Example
            //This example uses the Id,Name which are in partial file1 and sets using the constructor in file2. 
            //this says the methods, variables can be accessed b/w the two or more partial classes

            // PartialClass yp=new PartialClass(1,"Thiluck");
            // yp.GetDetails();
            #endregion


            #region Static Class Example, which can be used as Extensions
            // Example1
            // GeneralUsers.GetRollNo();

            // Example2
            if ("12Madam21".IsPalindrome()) 
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            #endregion


        }
    }
}