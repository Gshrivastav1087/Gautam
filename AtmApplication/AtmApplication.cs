using System;

// ATM application to handle user interactions
public class AtmApplication
{
    private readonly Bank bank;

    public AtmApplication() => bank = new Bank(); // Create a new bank with default accounts

    // Method to run the ATM application
    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to the ATM!");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
            Console.WriteLine("3. Exit");
            Console.Write("Please choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    SelectAccount();
                    break;
                case "3":
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        }
    }

    // Method to create a new account
    private void CreateAccount()
    {
        int accountNumber = GetValidAccountNumber("Enter account number (100-1000): ");
        double initialBalance = GetValidDouble("Enter initial balance: ");
        double interestRate = GetValidInterestRate("Enter interest rate (up to 3%): ");
        string accountHolderName = GetValidName("Enter account holder's name: ");

        var newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
        bank.AddAccount(newAccount);
        Console.WriteLine("Account created successfully!");
    }

    // Method to select an existing account
    private void SelectAccount()
    {
        int accountNumber = GetValidAccountNumber("Enter your account number: ");
        Account account = bank.RetrieveAccount(accountNumber);

        if (account != null)
        {
            AccountMenu(account);
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }

    // Menu for account operations
    private void AccountMenu(Account account)
    {
        while (true)
        {
            Console.WriteLine($"\nWelcome, {account.AccountHolderName}!");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. View Transactions");
            Console.WriteLine("5. Exit Account");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    account.DisplayBalance();
                    break;
                case "2":
                    double depositAmount = GetValidDouble("Enter amount to deposit: ");
                    account.Deposit(depositAmount);
                    break;
                case "3":
                    double withdrawAmount = GetValidDouble("Enter amount to withdraw: ");
                    account.Withdraw(withdrawAmount);
                    break;
                case "4":
                    account.DisplayTransactions();
                    break;
                case "5":
                    return; // Exit account menu
                default:
                    Console.WriteLine("Invalid option. Try again!");
                    break;
            }
        }
    }

    // Method to get a valid account number from user
    private int GetValidAccountNumber(string prompt)
    {
        int accountNumber;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out accountNumber) && accountNumber >= 100 && accountNumber <= 1000)
            {
                return accountNumber;
            }
            Console.WriteLine("Invalid input. Please enter a number between 100 and 1000.");
        }
    }

    // Method to get a valid positive double from user
    private double GetValidDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
            {
                return value;
            }
            Console.WriteLine("Please enter a valid positive number.");
        }
    }

    // Method to get a valid interest rate
    private double GetValidInterestRate(string prompt)
    {
        double interestRate;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out interestRate) && interestRate >= 0 && interestRate <= 3)
            {
                return interestRate;
            }
            Console.WriteLine("Interest rate must be between 0 and 3. Try again!");
        }
    }

    // Method to get a valid account holder name
    private string GetValidName(string prompt)
    {
        string name;
        while (true)
        {
            Console.Write(prompt);
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name) && IsAlphabetic(name))
            {
                return name;
            }
            Console.WriteLine("Name can only contain alphabetic characters. Please enter a valid name.");
        }
    }

    // Helper method to check if a string contains only alphabetic characters
    private static bool IsAlphabetic(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c) && !char.IsWhiteSpace(c)) // Allow spaces for names like "John Doe"
            {
                return false;
            }
        }
        return true;
    }
}
