using System.Collections.Generic;

public class Bank
{
    // Defining dynamic size List to store accounts to add more accounts when new
    // accounts are created.
    private List<Account> accounts = new List<Account>();

    public Bank()
    {
        // Create and initialize 10 default accounts with account numbers from 100
        // to 109. Each account starts with a balance of 100 and an interest rate of
        // 3%.
        for (int i = 100; i <= 109; i++)
        {
            accounts.Add(new Account(i, 100, $"AccountHolder{i}", 0.03));
        }
    }

    public Account RetrieveAccount(int accountNumber)
    {
        foreach (var account in accounts)
        {
            if (account.AccountNumber == accountNumber)
            {
                return account;
            }
        }
        return null;  // Account not found
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }
}
