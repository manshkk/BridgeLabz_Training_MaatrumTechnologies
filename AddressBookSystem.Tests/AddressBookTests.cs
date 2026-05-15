using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressBookSystem.Tests
{
    [TestClass]
    public class AddressBookTests
    {
        [TestMethod]
        public void AddContact_ValidContact_ShouldAddSuccessfully()
        {
            // Arrange
            AddressBook book = new AddressBook();

            Contact contact = new Contact
            {
                FirstName = "Manish",
                LastName = "Kumar",
                City = "Chennai",
                State = "Tamil Nadu",
                PhoneNumber = "9876543210",
                Email = "manish@gmail.com"
            };

            // Act
            book.AddContactForTest(contact);

            // Assert
            Assert.AreEqual(1, book.GetContactCount());
        }

        [TestMethod]
        public void SearchContact_ExistingContact_ShouldReturnTrue()
        {
            // Arrange
            AddressBook book = new AddressBook();

            Contact contact = new Contact
            {
                FirstName = "Rahul",
                City = "Delhi"
            };

            book.AddContactForTest(contact);

            // Act
            bool result = book.SearchContact("Rahul");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SearchContact_NotExistingContact_ShouldReturnFalse()
        {
            // Arrange
            AddressBook book = new AddressBook();

            // Act
            bool result = book.SearchContact("Amit");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeleteContact_ExistingContact_ShouldDeleteSuccessfully()
        {
            // Arrange
            AddressBook book = new AddressBook();

            Contact contact = new Contact
            {
                FirstName = "Kiran"
            };

            book.AddContactForTest(contact);

            // Act
            book.DeleteContact("Kiran");

            // Assert
            Assert.AreEqual(0, book.GetContactCount());
        }

        [TestMethod]
        public void AddDuplicateContact_ShouldNotIncreaseCount()
        {
            // Arrange
            AddressBook book = new AddressBook();

            Contact contact1 = new Contact
            {
                FirstName = "Manish"
            };

            Contact contact2 = new Contact
            {
                FirstName = "Manish"
            };

            // Act
            book.AddContactForTest(contact1);
            book.AddContactForTest(contact2);

            // Assert
            Assert.AreEqual(1, book.GetContactCount());
        }
    }
}