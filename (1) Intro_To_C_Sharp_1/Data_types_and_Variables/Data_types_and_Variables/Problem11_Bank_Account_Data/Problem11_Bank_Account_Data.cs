// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class Problem11_Bank_Account_Data
{
    static void Main()
    {
        Console.Write("The account holder name is (first, middle and last name): ");
        string accountHolderName = Console.ReadLine();
        Console.Write("Available amount of money: ");
        decimal accountBalance = Convert.ToDecimal(Console.ReadLine());
        Console.Write("The bank name is: ");
        string bankName = Console.ReadLine();
        Console.Write("The IBAN of the account is: ");
        string accountIBAN = Console.ReadLine();
        Console.Write("First credit card number: ");
        ulong firstCreditCardNumber = Convert.ToUInt64(Console.ReadLine());
        Console.Write("Second credit card number: ");
        ulong secondCreditCardNumber = Convert.ToUInt64(Console.ReadLine());
        Console.Write("Third credit card number: ");
        ulong thirdCreditCardNumber = Convert.ToUInt64(Console.ReadLine());
    }
}
