﻿using NUnit.Framework;
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
        public void EvenNumberCheck_ReturnFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            bool evenInput = calculator.IsOddNumber(2);
            // Assert
            Assert.IsFalse(evenInput);
        }
    }
}
