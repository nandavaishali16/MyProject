using System;
using System.Threading;

class Account
{
    public int AccountId { get; set; }
    public double AccountBalance { get; set; }

    public Account(int accountId, double balance)
    {
        AccountId = accountId;
        AccountBalance = balance;
    }
}

class AccountManager
{
    public Account FromAccount { get; set; }
    public Account ToAccount { get; set; }
    public double AmountToTransfer { get; set; }

    public void Transfer()
    {
        if (FromAccount.AccountBalance >= AmountToTransfer)
        {
            FromAccount.AccountBalance -= AmountToTransfer;
            ToAccount.AccountBalance += AmountToTransfer;
            Console.WriteLine($"Transferred {AmountToTransfer} from Account {FromAccount.AccountId} to Account {ToAccount.AccountId}");
        }
        else
        {
            Console.WriteLine("Insufficient balance in the source account.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account accountA = new Account(1, 5000);
        Account accountB = new Account(2, 2000);

        AccountManager manager = new AccountManager
        {
            FromAccount = accountA,
            ToAccount = accountB,
            AmountToTransfer = 1000
        };

        Thread transferThread = new Thread(manager.Transfer);
        transferThread.Start();
        transferThread.Join(); // Wait for the thread to complete

        Console.WriteLine($"Account A Balance: {accountA.AccountBalance}");
        Console.WriteLine($"Account B Balance: {accountB.AccountBalance}");
        Console.ReadLine();
    }
}