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
        public void SubtractInputTwoInt_GetCorrectSubtraction()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int result = calculator.Subtract(50, 25);
            //Assert
            Assert.AreEqual(25, result);
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
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            return calculator.IsOddNumber(a);
        }

        [Test]
        [TestCase(20.33,60.33)]
        [TestCase(40.33,40.33)]
        public void DoubleSum_InputTwoInt_GetCorrectAdition(double a, double b)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            double result = calculator.SumDouble(a, b);
            // Assert
            Assert.AreEqual(80.66, result, 1);
        }

        [Test]
        public void OddRanger_InputMinMaxRange_ReturnValidOddRrange()
        {
            // Arrange
            Calculator calculator = new Calculator();
            List<int> expectedOddRange = new List<int> { 5, 7, 9 }; // 5-10
            List<int> expectedOddRange2 = new List<int> { 0, 0, 0 }; // 5-8 for testing test purposes
            // Act
            List<int> result = calculator.GetOddRange(5,10); // 5, 7, 9
            // Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            // Assert.AreEqual(expectedOddRange, result); // This is the same as line 93
            Assert.Contains(9,result);
            Assert.That(result, Does.Contain(9));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(8));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Ordered.Ascending);
            Assert.That(result, Is.Unique);
            Assert.That(result, Has.Count.GreaterThan(1));
            Assert.That(result, Has.All.Positive);
            Assert.That(result, Contains.Item(5));
        }
    }
}
