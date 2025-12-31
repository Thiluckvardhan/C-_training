using System.Text.RegularExpressions;
namespace Day10
{
    /// <summary>
    /// Demonstrates regex pattern matching with timeout handling.
    /// Shows how to use regular expressions with a specified timeout duration.
    /// </summary>
    public class RegexTimeout
    {
        /// <summary>
        /// Checks if a pattern is found in the input string with a timeout.
        /// Uses case-insensitive pattern matching and 150ms timeout.
        /// </summary>
        public void Check()
        {
            // Input string to search in
            string input = "Error: TIMEOUT While Calling API";
            
            // Pattern to search for (case-insensitive)
            string pattern = @"timeout";

            // Create regex with timeout of 150 milliseconds
            // RegexOptions.IgnoreCase makes the search case-insensitive
            var rx = new Regex(pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(150));
            
            // Display the result: "Found" if pattern matches, "Not Found" otherwise
            System.Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");
        }
    }
}