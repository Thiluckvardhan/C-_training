using System;

namespace Day1
{
    class CheckEvenorOdd
{ 
    public static void Check()
    {
        Console.WriteLine("Enter the Number to find Even or Odd or ('q' to quit)");
        String? choice= Console.ReadLine();
        String checkresult=String.Empty;
        int number=0;
        while(!(choice=="q" || choice =="Q"))
        {
            number=int.TryParse(choice,out number)?number:0;
            checkresult=IsEven(number)?"Even":"Odd";
            Console.WriteLine(checkresult);

        Console.WriteLine("Enter the Number to find Even or Odd or ('q' to quit)");
        choice= Console.ReadLine();
        }
    }
    static bool IsEven(int number)
    {
        return number%2==0;
    }
}
}