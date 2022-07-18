using Xunit;

namespace TestingSolution.xUnit
{
    public class BankAccountxUnitTest
    {
        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Fact]
        public void Test_CheckingCorrectBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            var retrievedBalance = bankAccount.Balance;

            //Assert
            Assert.Equal(100, retrievedBalance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Fact]
        public void Test_Debit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.Equal(50, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [Fact]
        public void Test_Debit_Transaction_With_Same_Balance_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);

            //Act
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.Equal(100, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Fact]
        public void Test_Credit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);

            //Assert
            Assert.Equal(200, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Fact]
        public void Test_Credit_Transaction_With_More_Balance_Expected_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);

            //Assert
            Assert.Equal(300, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [Fact]
        public void Test_Credit_And_Debit_Transaction_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);
            bankAccount.Debit_Transaction(50);

            //Assert
            Assert.Equal(150, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [Fact]
        public void Test_Credit_And_Debit_Transaction_With_More_Expected_Balance_ValidatingBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount("MS Shaikh", 150);

            //Act
            bankAccount.Credit_Transaction(50);
            bankAccount.Debit_Transaction(50);
            
            //Assert
            Assert.Equal(200, bankAccount.Balance);
        }
    }
}