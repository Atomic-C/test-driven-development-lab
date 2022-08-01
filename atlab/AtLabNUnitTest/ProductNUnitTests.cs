using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    [TestFixture]
    public class ProductNUnitTests
    {
        public Product Product;
        public Customer Customer { get; set; }
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void GetPrice_InputPremiumCustomer_ReturnPriceForPremiumCustomer()
        {
            // Arrange
            Product = new Product() { Price = 500 };
            Customer = new Customer() { IsPremium = true };
            // Act
            var result = Product.GetPrice(Customer);
            // Assert 
            Assert.That(result, Is.EqualTo(400));
        }

        [Test]
        public void GetPrice_MOQMisUse_InputPremiumCustomer_ReturnPriceForPremiumCustomer()
        {
            // Arrange
            Product = new Product() { Price = 500 };
            var customerMock = new Mock<ICustomer>();
            customerMock.Setup(u => u.IsPremium).Returns(true);
            //Customer = new Customer() { IsPlatinum = true }; // We're mocking this
            // Act
            var result = Product.GetPrice(customerMock.Object);
            // Assert
            Assert.That(result, Is.EqualTo(400));
        }
    }
}
