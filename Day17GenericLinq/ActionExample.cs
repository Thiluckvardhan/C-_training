using System.Runtime.CompilerServices;

namespace Day17
{
    public class ActionExample
    {
        public ActionExample()
        {
            // ---------------------------------------------------------------------------------
            // Action
            // use case: for methods that return void 
            // often used for logging, printing, or updating UI.
            // ----------------------------------------------------------------------------------

            // Example 1
            Action<string> logger = message =>
            {
                Console.WriteLine($"[Log]: {message} at {DateTime.Now}");
            };

            logger = message =>
            {
                Console.WriteLine($"[Log]: {message} at sdlkfjdsjfl;sl;df {DateTime.Now}");
            };

            logger("Application Started"); //Invoking the Action, this will call the second logger message.


            // Example 2 using Methods in Action

            logger = NewMethod();

            if (DateTime.Now.Hour < 12)
            {
                logger = GoodMoring();
            }
            else
            {
                logger = GoodDay();
            }

            logger("dd");




            logger = Method2();

            logger("Application Started"); // Invoking the Action

        }

        private static Action<string> GoodDay()
        {
            throw new NotImplementedException();
        }

        private static Action<string> NewMethod()
        {
            //MyGlobalType<UGStudent> myGlobalType = new MyGlobalType<UGStudent>();
            ////MyGlobalType<Object> myGlobalType1 = new MyGlobalType<Object>();

            //UGStudent obj = new UGStudent();
            //string result = myGlobalType.GetDataType(obj);
            //Console.WriteLine(result);
            //Console.ReadLine();



            return message =>
            {
                Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");
            };
        }

        private static Action<string> GoodDay(string str)
        {
            return message =>
            {
                Console.WriteLine($"Good Day to you");
            };
        }

        private static Action<string> GoodMoring()
        {
            return message =>
            {
                Console.WriteLine($"Good Morning");
            };
        }

        private static Action<string> Method1()
        {
            return message =>
            {
                Console.WriteLine($"[LOG]: {message.ToUpper()} at {DateTime.Now}");
            };
        }

        private static Action<string> Method2()
        {
            return message =>
            {
                Console.WriteLine($"Welcome to Programming");
            };
        }
    }
}
