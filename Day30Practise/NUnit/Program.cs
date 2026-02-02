using NUnit.Framework;

public class BankAccount
{
    public decimal Balance { get; set; }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Deposit amount cannot be negative");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Insufficient funds");
        }
        Balance -= amount;
    }
}

[TestFixture]
public class UnitTest
{
    private BankAccount? account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount(1000);
    }

    [Test]
    public void Test_Deposit_ValidAmount()
    {
        account!.Deposit(500);
        Assert.That(account.Balance, Is.EqualTo(1500));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Assert.Throws<Exception>(() => account!.Deposit(-100));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        account!.Withdraw(300);
        Assert.That(account.Balance, Is.EqualTo(700));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Assert.Throws<Exception>(() => account!.Withdraw(1500));
    }
}
