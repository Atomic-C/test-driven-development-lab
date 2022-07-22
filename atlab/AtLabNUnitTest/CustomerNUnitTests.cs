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
            Assert.That(fullName, Is.EqualTo("Pedro Sousa")); // Checks if fullName Is.EquLTo(the expected full name!)
        }
    }
}
