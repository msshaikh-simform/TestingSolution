using NUnit.Framework;

namespace TestingSolution.nUnit
{
    public class BankAccountnUnitTest
    {
        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Test]
        public void Test_CheckingCorrectBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            var retrievedBalance = bankAccount.Balance;

            //Assert
            Assert.AreEqual(100, retrievedBalance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Test]
        public void Test_Debit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.AreEqual(50, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [Test]
        public void Test_Debit_Transaction_With_Same_Balance_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.AreEqual(100, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Test]
        public void Test_Credit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);

            //Assert
            Assert.AreEqual(200, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Test]
        public void Test_Credit_Transaction_With_More_Balance_Expected_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);

            //Assert
            Assert.AreEqual(300, bankAccount.Balance);
        }

        [Test]
        public void Test_Credit_And_Debit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.AreEqual(150, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [Test]
        public void Test_Credit_And_Debit_Transaction_With_More_Expected_Balance_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.AreEqual(200, bankAccount.Balance);
        }
    }
}