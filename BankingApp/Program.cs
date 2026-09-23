void BuildingBankingApp()
{
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("==========================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    choice = Convert.ToInt32(Console.ReadLine());

    // Valid menu choice
    if (choice == 1 || choice == 2)
    {
        // Valid menu choice
        if (choice == 1)
        {
            // Deposit or withdraw funds
            Console.WriteLine("You have chosen to deposit or withdraw funds");
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter amount including pence using a decimal point");

            // Typically a currency value is input as a decimal value
            // so the "double" type is required to store the
            // deposit amount.

            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your original account balance was {accountBalance}");

            // This line of code is interpreted as
            // account balance = account balance + deposit amount
            // This is an example of an assignment operator
            accountBalance += depositAmount;
            Console.WriteLine($"Your new account balance is {accountBalance}");
        }
        if (choice == 2)
        {

        }
        else
        {
            // View current account information
            accountBalance = 1000.00;
            Console.WriteLine($"Your current account balance is {accountBalance}");
        }
    }
    if (choice == 2)
    {
        // View current account information
        Console.WriteLine("You have chosen to view current account information");
        Console.WriteLine($"Your current account balance is {accountBalance}");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select a valid option.");
    }
}
    BuildingBankingApp();
