using System.Text;

namespace WordWandALanguageModel
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("------------Welcome To Word Wand----------------");
            System.Console.Write("Enter Input: ");
            string input=Console.ReadLine();
            foreach(char letter in input)
            {
                if(!(char.IsWhiteSpace(letter) || char.IsLetter(letter)))
                {
                    System.Console.WriteLine("invalid sentence");
                    return;
                }
            }
            // foreach(char letter in input)
            // {
            //     if (char.IsWhiteSpace(letter))
            //     {
            //         count++;
            //     }
            // }
            List<string> strings=input.Split(' ').ToList();
            int count=strings.Count();
            if (count % 2 == 0)
            {
                StringBuilder result= new StringBuilder();
                for(int i = count - 1; i >= 0; i--)
                {
                    result.Append(strings[i]);
                    if(i!=0)result.Append(" ");
                }
                System.Console.WriteLine(result);
            }
            else
            {
                StringBuilder result= new StringBuilder();
                int length=0;
                string resultitem="";
                foreach(string item in strings)
                {
                    length=item.Length;
                    for(int i = length - 1; i >= 0; i--)
                    {
                        resultitem+=item[i];
                    }
                    result.Append(resultitem);
                    result.Append(" ");
                    resultitem="";
                }
                System.Console.WriteLine(result);
            }
        }
    }
}