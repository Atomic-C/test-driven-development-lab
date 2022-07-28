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
    public class BankAccountNUnitTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BankDeposit_DummyLogBook_100USD_ReturnTrue()
        {
            // Arrange
            BankAccount bankAccount = new BankAccount(new DummyLogBook());
            // Act
            var result = bankAccount.Deposit(100);
            // Assert
            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }        
        
        [Test]
        public void BankDeposit_Mocked_100USD_ReturnTrue()
        {
            // Arrange
            var logMock = new Mock<ILogBook>();
            BankAccount account = new BankAccount(logMock.Object);
            // Act
            var result = account.Deposit(100);
            // Assert
            Assert.IsTrue(result);
            Assert.That(account.GetBalance, Is.EqualTo(100));
        }
    }
}
