using NUnit.Framework;
using Account;

namespace Account.Test
{
    public class Tests
    {
        [Test]
        public void CheckTheDeposit_AccountNameMatt_Result1000()
        {
            //Arrange
            Account account = new Account("Matt's account", 1000);

            //Act
            var result = account.Balance();

            //Assert
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void CheckToString_AccountNameMattTheBalance1000_ResultMatt1000()
        {
            //Arrange
            Account account = new Account("Matt's account", 1000);

            //Act
            var result = account.ToString();

            //Assert
            Assert.AreEqual("Matt's account: 1000", result);
        }

        [Test]
        public void CheckTransfer_AccountNameMattTheBalance1000Transfer100ToAnotherAccountWhichBalanceIs10_Result110()
        {
            //Arrange
            Account account1 = new Account("Matt's account", 1000);
            Account account2 = new Account("Tramp account", 10);

            //Act
            Account.Transfer(account1, account2, 100);

            //Assert
            Assert.AreEqual(110,account2.Balance());
        }
    }
}