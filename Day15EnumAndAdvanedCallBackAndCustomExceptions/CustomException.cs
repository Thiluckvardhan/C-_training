using System.Reflection.Metadata;

namespace Day15
{
    public class CustomException : Exception
    {
        public override string Message =>HandleBase(base.Message);  //In this way we can store the exception message and also not show the excpetion outside

        public string HandleBase(string sysMessage)
        {
            //Original Message from base Class
            Console.WriteLine(sysMessage);
            return "Internal Exception Occurred. Please contact Admin.";
        }
    }
    

}