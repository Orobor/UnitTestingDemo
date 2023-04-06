using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingDemo.Tests
{
    [TestClass()]
    public class eWalletTests
    {

        [TestMethod()]
        public void WithdrawTest_WithValidAmount_UpdatedBalance()
        {
            //Arrange
            double currentBalance = 100;
            double withdrawAmount = 40;
            double expectedBalance = 60;

            var account = new eWallet(currentBalance);

            //Act
            var result = account.Withdraw(withdrawAmount);

            //Assert
            Console.WriteLine(result);
            Assert.AreEqual(expectedBalance, result);

        }

        
    }
}