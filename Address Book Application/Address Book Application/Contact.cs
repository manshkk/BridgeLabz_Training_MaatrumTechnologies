using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Application
{
    public class Contact
    {
        

        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public Contact(string firstName, string phoneNumber, string city)
        {
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            City = city;
        }

        public void Display()
        {
            Console.WriteLine(FirstName + ", " + PhoneNumber + ", " + City);
        }
    }
}
