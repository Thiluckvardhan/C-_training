namespace Day9
{
    public static class StringExtensions
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <returns>True if the string is a palindrome; otherwise, false.</returns>
        public static bool IsPalindrome(this string str)
        {
            // Initialize pointers: left at start, right at end
            int size = str.Length;
            char leftcheck;
            char rightcheck;
            int left = 0;
            int right = size - 1;

            // Compare characters from both ends moving towards center
            while (left < right)
            {
                leftcheck=str[left];
                rightcheck=str[right];
                if (char.IsLetter(leftcheck) && char.IsLetter(rightcheck))
                {
                    leftcheck=char.ToLower(leftcheck);
                    rightcheck=char.ToLower(rightcheck);
                }
                else if(!(char.IsDigit(leftcheck) && char.IsDigit(rightcheck))){
                    return false;
                }
                // If characters don't match, string is not a palindrome
                if (leftcheck != rightcheck)
                {
                    return false;
                }
                // Move pointers closer to center
                left++;
                right--;
            }

            // If loop completes, all characters matched - it's a palindrome
            return true;
        }
    }
}