using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    [TestFixture]
    class CalculatorNUnitTests
    {
        [Test]
        public void Sum_InputTwoInt_GetCorrectAdition()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int result = calculator.Sum(2, 2);
            // Assert
            
            Assert.AreEqual(4, result);
        }

        [Test]
        public void OddNumberCheck_ReturnTrue()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool oddInput = calculator.IsOddNumber(1);
            // Assert
            Assert.IsTrue(oddInput);
        }        
        
        [Test]
        [TestCase(2)]
        [TestCase(400)] // When using test cases we can test multiple values
        public void EvenNumberCheck_ReturnFalse(int a)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool evenInput = calculator.IsOddNumber(a);
            // Assert
            Assert.IsFalse(evenInput);
        }

        [Test]
        [TestCase(20, ExpectedResult = false)]
        [TestCase(21, ExpectedResult = true)]
        public bool IsOddChecker_InputNumberReturnTrueIfOdd(int a)
        {
            // Arranje
            Calculator calculator = new Calculator();
            // Act
            return calculator.IsOddNumber(a);
        }
    }
}
