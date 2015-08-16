// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class Problem_2_Print_Company_Information
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company phone number: ");
        int companyPhoneN = Int32.Parse(Console.ReadLine());
        Console.Write("Company fax number: ");
        int companyFaxN = Int32.Parse(Console.ReadLine());
        Console.Write("Company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Company manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Company manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = Int32.Parse(Console.ReadLine());
        Console.Write("Manager phone number: ");
        int managerPhoneNumber = Int32.Parse(Console.ReadLine());

        Console.WriteLine("The company name is {0} and its adress is {1}. The phone number of the company is {2}, its fax number {3} and its manager {4} {5}. {4} {5} is {6} years old and his number is {7}.",
            companyName, companyAddress, companyPhoneN, companyFaxN, managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}
