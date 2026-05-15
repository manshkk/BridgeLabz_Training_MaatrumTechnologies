using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample.Controllers;

namespace UnitTestExample.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeController_Index_ValidResult()
        {
            // Arrange
            HomeController controller = new HomeController();
            string expected = "Hello, World! Manish i am in home";

            // Act
            string result = controller.Index();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}