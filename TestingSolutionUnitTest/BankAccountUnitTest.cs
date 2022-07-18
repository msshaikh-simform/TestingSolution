using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingSolution.UnitTest
{
    [TestClass()]
    public class BankAccountTests
    {
        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [TestMethod()]
        public void Test_Debit_Transaction_WhenBalanceExists()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);
            try
            {
                bankAccount.Debit_Transaction(50);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Sorry, you've entered amount greater than your existing balance!");
                Assert.Fail("Test failed: User has entered amount > existing balance!");
                return;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Amm, Sorry. Your balance is 0!");
                Assert.Fail("Test failed: User has entered amount as 0!");
                return;
            }
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [TestMethod()]
        public void Test_Debit_Transaction_WhenBalanceExistsAndAmountIsGreaterThanBalance()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 100);
            try
            {
                bankAccount.Debit_Transaction(1000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Sorry, you've entered amount greater than your existing balance!");
                Assert.Fail("Test failed: User has entered amount > existing balance!");
                return;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Amm, Sorry. Your balance is 0!");
                Assert.Fail("Test failed: User has entered amount as 0!");
                return;
            }
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [TestMethod()]
        public void Test_Debit_Transaction_WhenBalanceIsZero()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 0);
            try
            {
                bankAccount.Debit_Transaction(100);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Sorry, you've entered amount greater than your existing balance!");
                Assert.Fail("Test failed: User has entered amount > existing balance!");
                return;
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Amm, Sorry. Your balance is 0!");
                Assert.Fail("Test failed: User has entered amount as 0!");
                return;
            }
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [TestMethod()]
        public void Test_Credit_Transaction_WhenBalanceExists()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 10);
            bankAccount.Credit_Transaction(20);
            Assert.AreEqual(30, bankAccount.Balance);
        }

        /// <summary>
        /// Expected result: Failed
        /// </summary>
        [TestMethod()]
        public void Test_Credit_Transaction_WhenAmountIsZeroEntered()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 20);
            try
            {
                bankAccount.Credit_Transaction(0);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "Oops, amount is less than or equal to 0.");
                Assert.Fail("Test failed: User has entered amount less or equal to 0!");
                return;
            }
        }

        /// <summary>
        /// Expected result: Passed
        /// </summary>
        [TestMethod()]
        public void Test_Credit_Debit_Transaction_WhenBalanceExists()
        {
            BankAccount bankAccount = new BankAccount("MS Shaikh", 50);
            bankAccount.Credit_Transaction(20);
            bankAccount.Debit_Transaction(20);
            Assert.AreEqual(50, bankAccount.Balance);
        }
    }
}