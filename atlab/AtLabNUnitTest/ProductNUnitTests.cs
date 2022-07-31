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
            Customer = new Customer() { IsPlatinum = true };
            // Act
            var result = Product.GetPrice(Customer);
            // Assert 
            Assert.That(result, Is.EqualTo(400));
        }
    }
}
