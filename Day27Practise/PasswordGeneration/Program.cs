namespace PasswordGeneration
{
    public class Program
    {
        public static string IsValidUserName(string username)
        {
            if (username==null || username.Length != 8)
            {
                System.Console.WriteLine($"{username} is an invalid username");
                return " ";
            }
            string firstfour=username.Substring(0,4);
            foreach(char letter in firstfour)
            {
                if (!char.IsAsciiLetterUpper(letter))
                {
                    System.Console.WriteLine($"{username} is an invalid username");
                    return " ";
                }
            }
            if (username[4] != '@')
            {
                System.Console.WriteLine($"{username} is an invalid username");
                return " ";
            }
            string lastthree=username.Substring(5,3);
            foreach(char letter in lastthree)
            {
                if (!char.IsAsciiDigit(letter))
                {
                    System.Console.WriteLine($"{username} is an invalid username");
                    return " ";
                }
            }
            int.TryParse(lastthree,out int last);
            if (!(101 <= last && last <= 115))
            {
                System.Console.WriteLine($"{username} is an invalid username");
                return " ";
            }
            return username;
        }
        public static void Main()
        {
            System.Console.WriteLine("-------------------------Welcome to  TechXam------------------------");
            System.Console.Write("Enter your UserName: ");
            string username=Console.ReadLine();
            if (IsValidUserName(username) == " ")
            {
                return;
            }
            string password="TECH_";
            int asciisum=0;
            foreach(char letter in username.Substring(0, 4))
            {
                asciisum+=(int)char.ToLower(letter);        
            }
            string sum=asciisum.ToString();
            password+=sum;
            password+=username[6];
            password+=username[7];
            System.Console.WriteLine(password);
        }
    }
}