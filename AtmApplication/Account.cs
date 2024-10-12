using System;
using System.Collections.Generic;

public class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; private set; }
    public string AccountHolderName { get; set; }
    public double InterestRate { get; set; } =
        0.03;  // setting the Default value to 3%
    public List<string> Transactions { get; private set; } = new List<string>();

    // Holding the value of the last interest calculation timestamp.
    private DateTime lastInterestCalculation;

    public Account(int accountNumber, double initialBalance,
                   string accountHolderName, double interestRate)
    {
        AccountNumber = accountNumber;
        // Check if the initial balance is non-negative, otherwise throw an
        // exception
        Balance = initialBalance >= 0 ? initialBalance
                                      : throw new ArgumentException(
                                            "Initial balance cannot be negative.");
        InterestRate = interestRate;
        AccountHolderName = accountHolderName;
        Transactions.Add(
            $"Account created with balance: {Balance} and interest rate: {InterestRate * 100}%");
        lastInterestCalculation = DateTime.Now;  // Initialize with current time
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Transactions.Add($"Deposited: {amount.ToString("C")}");
        }
        else
        {
            throw new ArgumentException("Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Transactions.Add($"Withdrew: {amount.ToString("C")}");
        }
        else
        {
            throw new ArgumentException(
                "Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void DisplayTransactions()
    {
        Console.WriteLine("Transaction History");
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
    }

    public void CalculateInterest()
    {
        // Calculate the time span since the last interest calculation using inbuilt
        // class TimeSpan
        TimeSpan timeSinceLastCalculation = DateTime.Now - lastInterestCalculation;

        // Check if 10 seconds have passed
        if (timeSinceLastCalculation.TotalSeconds >= 10)
        {
            // Calculate the number of months based on elapsed time (10 seconds = 1
            // month)
            double monthsElapsed = timeSinceLastCalculation.TotalSeconds / 10;

            // Calculate the interest to be added in monthly interest
            double interest = Balance * InterestRate * monthsElapsed;

            // Update the balance with the calculated interest
            Balance += interest;
            Transactions.Add($"Interest applied: {interest.ToString("C")}");

            // Update the last interest calculation time
            lastInterestCalculation = DateTime.Now;
        }
    }
}
