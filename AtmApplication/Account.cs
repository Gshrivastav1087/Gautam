using System;
using System.Collections.Generic;

// Account class to represent a bank account
public class Account
{
    // Properties for the account details
    public int AccountNumber { get; }
    public double Balance { get; private set; }
    public double InterestRate { get; }
    public string AccountHolderName { get; }

    // A list to hold all transactions made on the account
    private readonly List<string> transactions;

    // Constructor to initialize account details
    public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        InterestRate = interestRate;
        AccountHolderName = accountHolderName;
        transactions = new List<string> { $"Account created with initial balance: ${initialBalance:F2}" };
    }

    // Method to display the current balance
    public void DisplayBalance() => Console.WriteLine($"Current Balance: ${Balance:F2}");

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("You need to deposit a positive amount.");
            return;
        }

        Balance += amount;
        transactions.Add($"Deposited: ${amount:F2}");
        Console.WriteLine("Deposit successful!");
    }

    // Method to withdraw money from the account
    public bool Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("You must enter a positive amount to withdraw.");
            return false;
        }
        if (amount > Balance)
        {
            Console.WriteLine("Oops! You don't have enough money.");
            return false;
        }

        Balance -= amount;
        transactions.Add($"Withdrew: ${amount:F2}");
        Console.WriteLine("Withdrawal successful!");
        return true;
    }

    // Method to display transaction history
    public void DisplayTransactions()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("No transactions made yet.");
            return;
        }

        Console.WriteLine("Transaction History:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
