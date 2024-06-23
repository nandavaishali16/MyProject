using System;

namespace BankingSystem
{
    public class Account
    {
        public double Balance { get; private set; }
        public string AccountType { get; private set; }

        public event EventHandler<TransactionEventArgs> ProcessingTransaction;
        public event EventHandler<TransactionEventArgs> TransactionComplete;

        public Account(double initialBalance, string accountType)
        {
            Balance = initialBalance;
            AccountType = accountType;
        }

        public void ProcessTransaction(double amount)
        {
            // Raise the ProcessingTransaction event
            OnProcessingTransaction(new TransactionEventArgs(amount, Balance, AccountType));

            // Perform the transaction
            Balance += amount;

            // Raise the TransactionComplete event
            OnTransactionComplete(new TransactionEventArgs(amount, Balance, AccountType));
        }

        protected virtual void OnProcessingTransaction(TransactionEventArgs e)
        {
            ProcessingTransaction?.Invoke(this, e);
        }

        protected virtual void OnTransactionComplete(TransactionEventArgs e)
        {
            TransactionComplete?.Invoke(this, e);
        }
    }

    public class TransactionEventArgs : EventArgs
    {
        public double Amount { get; }
        public double NewBalance { get; }
        public string AccountType { get; }

        public TransactionEventArgs(double amount, double newBalance, string accountType)
        {
            Amount = amount;
            NewBalance = newBalance;
            AccountType = accountType;
        }
    }

    public class Subscriber
    {
        public void Subscribe(Account account)
        {
            account.ProcessingTransaction += OnProcessingTransaction;
            account.TransactionComplete += OnTransactionComplete;
        }

        private void OnProcessingTransaction(object sender, TransactionEventArgs e)
        {
            Console.WriteLine($"Processing transaction of {e.Amount} on {e.AccountType} account...");
        }

        private void OnTransactionComplete(object sender, TransactionEventArgs e)
        {
            Console.WriteLine($"Transaction complete. New balance is {e.NewBalance} on {e.AccountType} account.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000, "Checking");
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(account);

            account.ProcessTransaction(500);

            Console.ReadLine();
        }
    }
}