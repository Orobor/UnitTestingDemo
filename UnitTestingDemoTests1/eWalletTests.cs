using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace UnitTestingDemo.Tests
{
    [TestClass()]
    public class eWalletTests
    {
        public const string DebitAmountExceedsBalanceMessage = "Insufficient Fund!";
        public const string DebitAmountLessThanZeroMessage = "Invalid Amount Specified!";

        [TestMethod()]
        public void WithdrawTest_WithValidAmount_ReturnBalance()
        {
            //Arrange
            double currentBalance = 100;
            double withdrawAmount = 40;
            double expectedBalance = 60;

            var account = new eWallet(currentBalance);

            //Act
            var result = account.Withdraw(withdrawAmount);

            //Assert
            Assert.AreEqual(expectedBalance, result);

        }
        
        [TestMethod()]
        public void WithdrawTest_AmountMoreThanBalance_ArgumentOutOfRangeException()
        {
            //Arrange
            double currentBalance = 100;
            double withdrawAmount = 400;

            var account = new eWallet(currentBalance);

            // Act
            try
            {
                account.Withdraw(withdrawAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");

        }

        [TestMethod()]
        public void WithdrawTest_AmountLessThanZero_ArgumentOutOfRangeException()
        {
            //Arrange
            double currentBalance = 100;
            double withdrawAmount = -10;

            var account = new eWallet(currentBalance);

            //Assert.ThrowsException<ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));

            // Act
            try
            {
                account.Withdraw(withdrawAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");

        }
    }
}