using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Application
{
    public class AddressBook
    {

        private Dictionary<char, List<Contact>> contactsDictionary;

        public AddressBook()
        {
            contactsDictionary = new Dictionary<char, List<Contact>>();
        }

        
        public void AddContact(Contact contact)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(contact.FirstName))
                {
                    throw new InvalidNameException("Name cannot be empty.");
                }

                char key = Char.ToUpper(contact.FirstName[0]);


                if (!contactsDictionary.ContainsKey(key))
                {
                    contactsDictionary[key] = new List<Contact>();
                }

                foreach (Contact existingContact in contactsDictionary[key])
                {
                    if (existingContact.FirstName == contact.FirstName)
                    {
                        throw new DuplicateContactException(
                            "Duplicate contact found.");
                    }
                }

                contactsDictionary[key].Add(contact);

                Console.WriteLine("Contact Added Successfully.");
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine("Name Error: "
                    + ex.Message);
            }
            
            catch (DuplicateContactException ex)
            {
                Console.WriteLine("Duplicate Error: "
                    + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: "
                    + ex.Message);
            }
            
        }
        private void SortContacts(
            List<Contact> contacts)
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = i + 1; j < contacts.Count; j++)
                {
                    if (string.Compare(contacts[i].FirstName, contacts[j].FirstName) > 0)
                    {

                        Contact temp = contacts[i];

                        contacts[i] = contacts[j];

                        contacts[j] = temp;
                    }
                }
            }
        }
        public void DisplayAllContacts()
        {
            try
            {
                foreach (KeyValuePair<char,List<Contact>> entry in contactsDictionary)
                {
                    char character = entry.Key;

                    List<Contact> contacts = entry.Value;

                   
                    SortContacts(contacts);

                    Console.WriteLine( "\n" + character + ": (Sorted by Name," + " Grouped by City)");


                    Dictionary<string, List<Contact>> cityGroups = new Dictionary<string,List<Contact>>();

                    foreach (Contact contact in contacts)
                    {
                        if (!cityGroups.ContainsKey(contact.City))
                        {
                            cityGroups[contact.City]= new List<Contact>();
                        }

                        cityGroups[contact.City] .Add(contact);
                    }

                    
                    foreach (KeyValuePair<string,List<Contact>> cityGroup in cityGroups)
                    {
                        Console.WriteLine("\nCity: " + cityGroup.Key);

                        foreach (Contact contact in cityGroup.Value)
                        {
                            contact.Display();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Display Error: "+ ex.Message);
            }
        }
    }

}

