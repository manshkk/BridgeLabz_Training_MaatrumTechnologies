/*
 Problem Statement: Address Book Application

Create a C# console-based Address Book application with the following requirements:

Create a data structure to store contacts where
the key is the first character of the contact’s first name, and
the value is a list of contacts.

Dictionary<char, List<Contact>>


Add contacts to the dictionary such that each contact is inserted
based on the first letter of their first name.

Display contacts according to the character entered by the user.

The displayed contacts should be sorted by name.

The contacts should be grouped by city while displaying.

A: (Sorted by name, grouped by city)
    Aakash, 9988776600, Bengaluru
    Abhilasha, 9876501100, Bengaluru
    Avantikaka, 9123456701, Bengaluru
    Aditya, 9000001112, Mumbai
    Aman, 9234567890, Mumbai
    Ananya, 9456123789, Pune

B: (Sorted by name, grouped by city)
    Babul, 9345612334, Delhi
    Bansi, 9567812300, Hyderabad
    Beena, 9988123456, Mumbai
    Bhanu, 9789012345, Mumbai

*/
using Address_Book_Application;
using System;

namespace Address_Book_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            
            addressBook.AddContact(new Contact("Aakash", "9988776600", "Bengaluru"));
            addressBook.AddContact(new Contact("Abhilasha", "9876501100", "Bengaluru"));
            addressBook.AddContact(new Contact("Avantika", "9123456701", "Bengaluru"));
            addressBook.AddContact(new Contact("Aditya", "9000001112", "Mumbai"));
            addressBook.AddContact(new Contact("Aman", "9234567890", "Mumbai"));
            addressBook.AddContact(new Contact("Ananya", "9456123789", "Pune"));

            addressBook.AddContact(new Contact("Babul", "9345612334", "Delhi"));
            addressBook.AddContact(new Contact("Bansi", "9567812300", "Hyderabad"));
            addressBook.AddContact(new Contact("Beena", "9988123456", "Mumbai"));
            addressBook.AddContact(new Contact("Bhanu", "9789012345", "Mumbai"));

            try
            {
                Console.Write("\nEnter Character: ");

                char input = Convert.ToChar(Console.ReadLine());

                addressBook.DisplayAllContacts();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}

