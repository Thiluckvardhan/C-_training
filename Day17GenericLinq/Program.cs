namespace Day17
{
    public class CallerClass
    {
        public static void Main()
        {
            // UGStudent ugStudent = new();
            // Object obj = new();

            // MyGlobalType<UGStudent, Object> myGlobalType = new();
            
            // var result = myGlobalType.GetDataType(ugStudent,obj);
            // Console.WriteLine(result);

            // predicate is a child of Delegate
            // predicateExample pe=new();//predicate Example

            //Action is also a child of Delegate
            // ActionExample ae=new();

            //Function Delegate Example 
            // FunctionDelegateExample fn=new();
            // Console.WriteLine(fn.multiplyResult(5,6)); // multiply result is a func <int,int,string> takes two ints as input and gives string as output

            //Thread Example
            // ThreadExample th=new();
            // th.Example1();

            //Async and Await Examples 
            // AsyncAwaitExample asy=new AsyncAwaitExample();
            // asy.CallMethod();
            // Console.ReadLine();

            //File Handling Example

            FileHandlingExample fh=new();
            fh.Example1();
        }
    }
}