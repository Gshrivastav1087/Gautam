using System;

public class AtmApplication
{
    private Bank bank;  // Creating object for bank class

    public AtmApplication()  // Constructor to initialise bank object.
    {
        bank = new Bank();
    }

    public void Start()
    {
        while (true)  // Loop to continuously display menu until user exits.
        {
            Console.WriteLine("\nWelcome to the ATM Application");
            Console.WriteLine();  // Add Line Break between options
            Console.WriteLine("ATM Main Menu");
            Console.WriteLine();  // Add Line Break between options
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
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
                    Console.WriteLine("Do you want to exit? [y/n]");
                    string exitChoice = Console.ReadLine().ToLower();

                    if (exitChoice == "y")
                    {
                        Console.WriteLine("Thank you for using the application!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        return;  // Exit the application
                    }
                    else if (exitChoice == "n")
                    {
                        break;  // Stay in the application and go back to the main menu
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Returning to the main menu...");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;  // Return to the main menu if input is not 'y' or 'n'
                    }
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();  // Wait for user input before continuing
                    break;
            }
        }
    }

    // Method to create new account
    private void CreateAccount()
    {
        Console.Write("Create Account");
        Console.WriteLine();
        Console.Write("Enter Account Number (between 100 to 1000): ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Initial Balance: ");
        double initialBalance = double.Parse(Console.ReadLine());

        Console.Write("Enter Account Holder's Name: ");
        string accountHolderName = Console.ReadLine();

        Console.Write(
            "Enter Annual Interest Rate (as a percentage,should be less than 3%): ");
        double interestRate = double.Parse(Console.ReadLine()) /
                              100;  // Convert percentage to a decimal

        Account newAccount = new Account(accountNumber, initialBalance,
                                         accountHolderName, interestRate);
        bank.AddAccount(newAccount);

        Console.WriteLine("Account created successfully!");

        // Prompting the user to create another account or return to the main menu
        Console.WriteLine(
            "Press any key to return to the main menu or enter '1' to create another account.");
        string input = Console.ReadLine();

        if (input == "1")
        {
            CreateAccount();
        }
    }

    // Method to select an account number
    private void SelectAccount()
    {
        Console.WriteLine();
        Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Account account = bank.RetrieveAccount(accountNumber);

        if (account != null)
        {
            AccountMenu(account);
        }
        else
        {
            Console.WriteLine("Account not found.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }
    }

    private void AccountMenu(Account account)
    {
        // Loop to continuously display menu until user exits
        while (true)
        {
            // Display account info and balance at the top
            Console.WriteLine();
            Console.WriteLine($"Welcome {account.AccountHolderName}");
            Console.WriteLine();
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Current Balance: {account.Balance.ToString("C")}");
            Console.WriteLine($"Annual Interest Rate: {account.InterestRate * 100}%");

            account.DisplayTransactions();  // Call to display transactions list

            // Display Menu options
            Console.WriteLine("\nChoose the Following Options:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Display Transactions");
            Console.WriteLine("5. Exit Account");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            // Call CalculateInterest at the start of each action to apply interest to
            // current balance
            account.CalculateInterest();

            switch (choice)
            {
                case "1":
                    // Checking Balance
                    Console.WriteLine($"Balance: {account.Balance.ToString("C")}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    // Deposit Amount
                    Console.Write("Enter amount to deposit: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine("Deposit successful.");
                    Console.WriteLine($"New Balance: {account.Balance.ToString("C")}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    // Withdraw amount
                    Console.Write("Enter amount to withdraw: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    try
                    {
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine("Withdrawal successful.");
                        Console.WriteLine($"New Balance: {account.Balance.ToString("C")}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    // Display transactions
                    account.DisplayTransactions();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "5":
                    // Display a bank statement before exiting the account menu
                    Console.WriteLine("Do you want to view the bank statement? (y/n)");
                    string showStatement = Console.ReadLine();
                    if (showStatement.ToLower() == "y")
                    {
                        BankStatement.DisplayStatement(account);
                    }
                    return;  // Exit account menu and return to main ATM menu
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
