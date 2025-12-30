namespace Day9
{
    public static class GeneralUsers
    {
        static int RollNo;
        static GeneralUsers(){
            RollNo=22;
        }
        public static void GetRollNo()
        {
            System.Console.WriteLine(RollNo);
        }
    }
}