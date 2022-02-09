using NUnit.Framework;
using Account;

namespace Account.Test
{
    public class Tests
    {
        [Test]
        public void Deposit_AccountMattBalance1000Deposit100_Result1100Balance()
        {
            //Arrange
            Account account = new Account("Matt's account", 1000);

            //Act
            var result = account.Deposit(100);

            //Assert
            Assert.AreEqual(1100, result);
        }

        [Test]
        public void ToString_AccountNameMattTheBalance1000_ResultMattAccount1000()
        {
            //Arrange
            Account account = new Account("Matt's account", 1000);

            //Act
            var result = account.ToString();

            //Assert
            Assert.AreEqual("Matt's account: 1000", result);
        }

        [Test]
        public void Transfer_AccountNameMattTheBalance1000Transfer100ToTramphBalance10_ResultTrampBalance110()
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