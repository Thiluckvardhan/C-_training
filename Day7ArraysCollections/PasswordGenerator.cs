namespace Day7
{
    #region PasswordGenerator
    /// <summary>
    /// Provides utilities for generating password-like values from text input.
    /// </summary>
    public class PasswordGenerator
    {
        #region CleanseAndInvert
        /// <summary>
        /// Returns the reversed sequence of letters with odd ASCII codes from the input when it is at least six characters and all letters; otherwise returns an empty string.
        /// </summary>
        public string CleanseAndInvert(string input)
        {
            #region Variable Declaration 
            char c;
            string temp = string.Empty;
            string result = string.Empty;
            #endregion

            #region Cleanse and Invert logic

            //This checks if input is NULL or input length is less than 6
            if (string.IsNullOrEmpty(input) || input.Length < 6)
            {
                return "Invalid Input";
            }


            //This Loop checks if the input only Contains Letters and no numbers,whitespace,special Characters
            for (int i = 0; i < input.Length; i++)
            {
                c = input[i];
                if (!char.IsLetter(c))
                {
                    return "Invalid Input";
                }
            }

            input = input.ToLower(); // change the input case to lower

            // Removes the letters which have even Ascii code 
            for (int i = 0; i < input.Length; i++)
            {
                int ascii = input[i];
                if (ascii % 2 != 0)
                {
                    temp += input[i];
                }
            }

            //Reverses the String
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    result += char.ToUpper(temp[i]);
                }
                else
                {

                    result += temp[i];
                }
            }
            return result;
            #endregion
        }
        #endregion
    }
    #endregion
}