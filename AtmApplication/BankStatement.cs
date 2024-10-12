using System;

public static class BankStatement
{
    // This method displays a formatted bank statement for a given account
    public static void DisplayStatement(Account account)
    {
        Console.WriteLine();
        Console.WriteLine("***Bank Statement***");
        Console.WriteLine($"Account Holder: {account.AccountHolderName}");
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance.ToString("C")}");
        Console.WriteLine($"Interest Rate: {account.InterestRate * 100}%");
        Console.WriteLine("Transaction History:");
        account.DisplayTransactions();  // calling this method displays the list of
                                        // all transactions

        Console.WriteLine();  // Adding a line break
    }
}
