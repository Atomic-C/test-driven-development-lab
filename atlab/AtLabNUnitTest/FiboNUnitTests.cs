using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    [TestFixture]
    public class FiboNUnitTests
    {
        public Fibo fibo;

        [SetUp]
        public void Setup()
        {
            fibo = new Fibo();
        }

        [Test]
        public void GetFiboSeries_Input_1_Return_NotEmpty_IsOrdered_Match0()
        {
            // Arrange
            // Fibo fibo = new Fibo(); // We already instantiated on Setup()
            // Act
            fibo.Range = 1;
            List<int> fiboResult = fibo.GetFiboSeries();
            List<int> fiboExpectedResult = new List<int>() { 0 };

            // Assert
            Assert.That(fiboResult, Is.Not.Empty);
            Assert.That(fiboResult, Is.Ordered);
            Assert.That(fiboResult, Is.EquivalentTo(fiboExpectedResult));
        }

        [Test]
        public void GetFiboSeries_Input_6_Return_Contains3_Count6_DoesNotContain4_ShouldMatch011235()
        {
            // Arrange
            // Fibo fibo = new Fibo(); // We already instantiated on Setup()
            List<int> expectedRange = new List<int>() { 0, 1, 1, 2, 3, 5 };
            fibo.Range = 6;
            // Act
            List<int> fiboResult = fibo.GetFiboSeries();
            // Assert
            Assert.That(fiboResult, Does.Contain(3));
            Assert.That(fiboResult.Count, Is.EqualTo(6));
            Assert.That(fiboResult, Does.Not.Contain(4));
            Assert.That(fiboResult, Is.EquivalentTo(expectedRange));
        }
    }
}
