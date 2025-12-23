using System;
using Day4;

/// <summary>
/// Entry point for Day4 examples demonstrating inheritance, try-catch, and constructors.
/// </summary>
class Program
{
    /// <summary>
    /// Application entry point. Uncomment lines to run specific examples.
    /// </summary>
    static void Main()
    {
        #region Method Logic
        // Day4
        // try{
        // Visitor vis=new Visitor(20,"Thiluck");
        // }
        // catch(Exception ex){
        //     Console.WriteLine(ex.Message);
        // }

        // AddtwoNumbersusingConstructor add=new AddtwoNumbersusingConstructor(2,5);

        // ExField employee =new ExField();
        // employee.Id=100;
        // string result=employee.DisplayEmpDetails();

        // try
        // {
        //     Emp emp = new Emp(-2, "", -3);
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        // Account account = new Account() { AccountId = 1, Name = "Account1" };
        // string result = account.GetAccountDetails();
        // SalesAccount salesAccount = new SalesAccount() { AccountId = 2, Name = "Balu", SalesInfo = "" };
        // var result1 = salesAccount.GetSalesAccountDetails();

        Father father=new Father();
        System.Console.WriteLine(father.InterestOn());
        Son son=new Son();
        System.Console.WriteLine(son.InterestOn());
        #endregion
    }
}

