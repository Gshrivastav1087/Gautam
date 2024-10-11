using System.Collections.Generic;

// Bank class to manage multiple accounts
public class Bank
{
    private readonly Dictionary<int, Account> accounts; // Use dictionary for faster lookups

    public Bank()
    {
        accounts = new Dictionary<int, Account>();
        InitializeDefaultAccounts();
    }

    // Method to create some default accounts
    private void InitializeDefaultAccounts()
    {
        for (int i = 100; i < 110; i++)
        {
            accounts[i] = new Account(i, 100.00, 3.0, $"Account Holder {i}");
        }
    }

    // Method to add a new account
    public void AddAccount(Account account) => accounts[account.AccountNumber] = account;

    // Method to retrieve an account by account number
    public Account RetrieveAccount(int accountNumber)
    {
        accounts.TryGetValue(accountNumber, out var account); // Use TryGetValue for efficiency
        return account; // Return null if account not found
    }
}
