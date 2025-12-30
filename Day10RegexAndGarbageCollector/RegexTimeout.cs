using System.Text.RegularExpressions;
namespace Day10
{
    public class RegexTimeout
    {
        public void Check()
        {
            string input = "Error: TIMEOUT While Calling API";
            string pattern = @"timeout";

            var rx = new Regex(pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(150));
            System.Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");
        }
    }
}