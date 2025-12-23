using System;
using Day4;

class Program
{
    static void Main()
    {

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


    }
}

