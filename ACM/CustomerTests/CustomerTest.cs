using ACM;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //  Arrange
            Customer customer = new Customer
            {
                FirstName = "Prakash",
                LastName = "Poudel"
            };
            string expected = "Poudel,Prakash";

            //  Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Poudel",
                EmailAddress = "poudel@gmail.com"
            };

            var expected = true;

            //Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
               
                EmailAddress = "poudel@gmail.com"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}