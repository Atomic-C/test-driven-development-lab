﻿using atlab;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtLabMSTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void Sum_InputTwoInt_GetCorrectAdition()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int result = calculator.Sum(2,2);
            // Assert
            
            Assert.AreEqual(4, result);
        }
    }
}
