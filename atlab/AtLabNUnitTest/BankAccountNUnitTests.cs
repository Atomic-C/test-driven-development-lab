﻿using NUnit.Framework;
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
        private BankAccount bankAccount;

        [SetUp]
        public void Setup()
        {
            bankAccount = new BankAccount(new DummyLogBook());
        }

        [Test]
        public void BankDeposit_100USD_ReturnTrue()
        {
            var result = bankAccount.Deposit(100);
            Assert.IsTrue(result);
            Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
        }
    }
}
