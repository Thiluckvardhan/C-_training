namespace Day2
{
    class VowelorConsonant
    {
        /// <summary>
        /// To check Vowel or Consonant
        /// </summary>
        public static void Check()
        {
            #region Variable Declaration
            char letter = ' ';
            #endregion

            #region Taking Input
            Console.Write("Enter a Letter to Check Vowel or Consonant: ");
            if (!char.TryParse(Console.ReadLine(), out letter))
            {
                Console.WriteLine("wrong input, Enter just a single character as input");
                return;
            }
            #endregion

            #region code Logic
            if (!char.IsLetter(letter))
            {
                Console.WriteLine("Not an alphabet");
                return;
            }
            letter = char.ToLower(letter);
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
            #endregion


        }
    }
}