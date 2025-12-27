using System.Collections;
namespace Day7
{
    /// <summary>
    /// Demonstrates various collection types in C#
    /// </summary>
    public class Collections
    {
        /// <summary>
        /// Sample method demonstrating ArrayList, Stack, Queue, and generic List collections
        /// </summary>
        public void Sample1()
        {
            #region ArrayList Example
            ArrayList myList = [];
            myList.Add(10);
            myList.Add("Hello");
            myList.Add(25.5);

            foreach ( var item in myList)
            {
                System.Console.WriteLine(item);
            }
            #endregion

            #region Stack Example
            Stack myStack = [];
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push("Stack Item");
            myStack.Pop();
            #endregion

            #region Queue Example
            Queue q = [];
            q.Enqueue("First");
            q.Enqueue(2);
            q.Enqueue(3.5);
            q.Dequeue();
            #endregion

            #region Generic List Examples

            // // List of strings
            // List<string> names = [];
            // names.Add("Alice");
            // names.Add("Charlie");
            // names.Add("Bob");

            // names.Sort();
            // foreach (var name in names)
            // {
            //     System.Console.WriteLine(name);
            // }

            // // List of integers
            // List<int> numbers = [];
            // numbers.Add(50);
            // numbers.Add(10);
            // numbers.Add(30);
            // numbers.Add(20);

            // numbers.Sort();
            // System.Console.WriteLine("Sorted Numbers:");
            // foreach (var num in numbers)
            // {
            //     System.Console.WriteLine(num);
            // }
            #endregion
        }
    }
}