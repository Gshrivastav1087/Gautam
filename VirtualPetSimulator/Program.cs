using System;

class VirtualPetSimulator
{
    // Declaration of Pet Status variables
    static int hunger = 5;     // where 0 = full, 10 = starving
    static int happiness = 5;  // where 0 = sad, 10 = happy
    static int health = 5;     // where 0 = tired, 10 = healthy

    static void Main(string[] args)
    {
        string petName;
        string petType = "";
        bool isValidChoice = false;

        // Do-while loop to display menu at least once until a valid choice is made.
        do
        {
            // Menu to select the pet
            Console.WriteLine("\nWelcome to Virtual Pet Simulator!");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("Please select the Type of Pet:");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Rat");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("Please enter your choice:");

            // Main logic for selecting pet
            string choice = Console.ReadLine();
            Console.WriteLine(); // Adding a blank line
            Console.WriteLine("User Input is: " + choice);
            Console.WriteLine(); // Adding a blank line

            switch (choice)
            {
                case "1":
                    petType = "Dog";
                    isValidChoice = true;
                    break;
                case "2":
                    petType = "Cat";
                    isValidChoice = true;
                    break;
                case "3":
                    petType = "Rat";
                    isValidChoice = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.\n");
                    break;
            }

        } while (!isValidChoice); // Loop to repeat until a valid choice is made

        Console.WriteLine(); // Add a blank line
        Console.WriteLine("You have selected a " + petType + ".");
        Console.WriteLine(); // Add a blank line

        // Naming the pet and printing welcome message
        Console.WriteLine("What would you like to name your " + petType + ":");
        petName = Console.ReadLine();
        Console.WriteLine(); // Add a blank line
        Console.WriteLine("Welcome, " + petName + "! Let's take good care of them.");
        Console.WriteLine(); // Add a blank line

        // Main loop for user actions
        bool exit = false; // Initializing exit to false
        while (!exit)
        {
            // Display current status of the pet
            Console.WriteLine(); // Add a blank line
            Console.WriteLine(petName + "'s status: ");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("Hunger: " + hunger + "/10 (0 = full, 10 = starving)");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("Happiness: " + happiness + "/10 (0 = sad, 10 = happy)");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("Health: " + health + "/10 (0 = tired, 10 = healthy)");
            Console.WriteLine(); // Add a blank line

            // Display actions menu
            Console.WriteLine("Main Menu: ");
            Console.WriteLine(); // Add a blank line
            Console.WriteLine("1. Feed " + petName);
            Console.WriteLine("2. Play with " + petName);
            Console.WriteLine("3. Rest " + petName);
            Console.WriteLine("4. Check status for " + petName);
            Console.WriteLine("5. Exit.");
            Console.WriteLine(); // Adding a blank line
            Console.WriteLine("Enter your choice:");
            string actionChoice = Console.ReadLine();
            Console.WriteLine(); // Add a blank line

            bool timeCheck = false;

            // Handling actions based on the user's choice
            if (actionChoice == "1")
            {
                if (hunger > 0)
                {
                    hunger -= 3;
                    health += 1;
                    if (hunger < 0) hunger = 0; // Ensure hunger doesn't go below 0
                    Console.WriteLine(petName + " has eaten.");
                    timeCheck = true;
                }
                else
                {
                    Console.WriteLine(petName + " is full.");
                }
            }
            else if (actionChoice == "2")
            {
                if (hunger >= 8)
                {
                    Console.WriteLine(petName + " is too hungry to play.");
                }
                else if (health <= 2)
                {
                    Console.WriteLine(petName + " is too tired to play.");
                }
                else
                {
                    happiness += 2;
                    if (happiness > 10) happiness = 10; // Ensure happiness doesn't exceed 10
                    health -= 2;
                    if (health < 0) health = 0; // Ensure health doesn't go below 0
                    Console.WriteLine(petName + " had fun playing!");
                    timeCheck = true;
                }
            }
            else if (actionChoice == "3")
            {
                if (health < 10)
                {
                    health += 4;
                    if (health > 10) health = 10; // Ensure health doesn't exceed 10
                    happiness -= 1;
                    Console.WriteLine(petName + " is resting.");
                    timeCheck = true;
                }
                else
                {
                    Console.WriteLine(petName + " doesn't need rest.");
                }
            }
            else if (actionChoice == "4")
            {
                // Display pet's current status without any action performed
                Console.WriteLine(); // Add a blank line
                Console.WriteLine(petName + "'s status: ");
                Console.WriteLine(); // Add a blank line
                Console.WriteLine("Hunger: " + hunger + "/10 (0 = full, 10 = starving)");
                Console.WriteLine(); // Add a blank line
                Console.WriteLine("Happiness: " + happiness + "/10 (0 = sad, 10 = happy)");
                Console.WriteLine(); // Add a blank line
                Console.WriteLine("Health: " + health + "/10 (0 = tired, 10 = healthy)");
                Console.WriteLine(); // Add a blank line
            }
            else if (actionChoice == "5")
            {
                // Exit the game
                Console.WriteLine(); // Add a blank line
                Console.WriteLine("Goodbye! See you again.");
                Console.WriteLine(); // Add a blank line
                exit = true;
                continue;
            }
            else
            {
                Console.WriteLine(); // Add a blank line
                Console.WriteLine("You have entered an invalid choice. Please try again.");
                Console.WriteLine(); // Add a blank line
            }

            // Simulate passage of time by increasing hunger and reducing happiness
            if (timeCheck)
            {
                hunger += 1;
                if (hunger > 10) hunger = 10;

                happiness -= 1;
                if (happiness < 0) happiness = 0;

                // Checking pet's status for warnings
                if (hunger >= 10)
                {
                    Console.WriteLine(); // Add a blank line
                    Console.WriteLine("Warning: " + petName + " is starving! Feed them soon.");
                    Console.WriteLine(); // Add a blank line
                }

                if (happiness <= 2)
                {
                    Console.WriteLine(); // Add a blank line
                    Console.WriteLine(petName + " is very sad. Play with them to cheer them up.");
                    Console.WriteLine(); // Add a blank line
                }

                if (health == 0)
                {
                    Console.WriteLine(); // Add a blank line
                    Console.WriteLine(petName + " is exhausted. Let them rest.");
                    Console.WriteLine(); // Add a blank line
                }

                // Display warning messages in case of neglect
                if (hunger == 10 && health > 0)
                {
                    health -= 2;
                    if (health < 0) health = 0;
                    Console.WriteLine(); // Add a blank line
                    Console.WriteLine(petName + "'s health is deteriorating due to hunger.");
                    Console.WriteLine(); // Add a blank line
                }

                if (happiness == 0 && health > 0)
                {
                    health -= 1;
                    if (health < 0) health = 0;
                    Console.WriteLine(); // Adding a blank line
                    Console.WriteLine(petName + "'s health is deteriorating due to unhappiness.");
                    Console.WriteLine(); // Add a blank line
                }
            }
        }
    }
}
