using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    [TestFixture]
   public  class CustomerNUnitTests
    {
        [Test]
        public void CombineCustomerName_InputFirstAndLastName_ReturnFfullName()
        {
            // Arrange
            Customer customer = new Customer();
            // Action
            string fullName = customer.CombineCustomerName("Pedro", "Sousa"); // Stores fullName
            // Assert
            Assert.That(fullName, Is.EqualTo("Hello, Pedro Sousa")); // Checks if fullName Is.EquLTo(the expected full name!)
            Assert.AreEqual(fullName, "Hello, Pedro Sousa"); // This is an alternative to line 21.

            // Below are some Assert Helper Methods that can be helpful with strings:

            Assert.That(fullName, Does.Contain("Pedro"));
            Assert.That(fullName, Does.StartWith("H"));
            Assert.That(fullName, Does.EndWith("a"));


            Assert.That(fullName, Does.Contain("pedro").IgnoreCase); // We can ignore case if needed.

            // Below is a regular expression that can be used with strings, making sure strings start with this pattern: 
            Assert.That(fullName, Does.Match("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]")); 
        }

        [Test]
        public void GreetMessage_NotGreeted_ShouldReturnNull()
        {
            // Arrange
            Customer customer = new Customer();
            // Act
            // Here we call nothing. We want to check the value of GreetMessage without calls.
            // Assert
            Assert.IsNull(customer.GreetMessage);
        }
    }
}
