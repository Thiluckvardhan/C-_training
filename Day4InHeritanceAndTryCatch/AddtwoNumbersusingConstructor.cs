using System;

namespace Day4
{
    public class AddtwoNumbersusingConstructor
    {
        int Num1 { get; set; }
        int Num2 { get; set; }
        int result { get; }
        private AddtwoNumbersusingConstructor()
        {
        }
        public AddtwoNumbersusingConstructor(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
            result = Num1 + Num2;
        }

        public void Print()
        {
            Console.WriteLine(Num1 + Num2);
        }
    }
}
