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
            Product = new Product() { Price = 500 };
            Customer = new Customer() { IsPlatinum = true };
        }
        [Test]
        public void GetPrice_ReturnPriceForPremium()
        {
            var result = Product.GetPrice(Customer);

            Assert.That(result, Is.EqualTo(400));
        }
    }
}
