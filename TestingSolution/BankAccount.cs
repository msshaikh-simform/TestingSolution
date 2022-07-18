using System;

namespace TestingSolution
{
    public class BankAccount
    {
        string _customerName;
        decimal _balance;

        public BankAccount(string customerName, decimal balance)
        {
            this._customerName = customerName;
            this._balance = balance;
        }

        public decimal Balance
        {
            get
            {
                return this._balance;
            }
        }

        public void Debit_Transaction(decimal amount)
        {
            if (_balance == 0)
            {
                throw new Exception("Amm, Sorry. Your balance is 0!");
            }

            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("Sorry, you've entered amount greater than your existing balance!");
            }

            _balance -= amount;
        }

        public void Credit_Transaction(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Oops, amount is less than or equal to 0.");
            }
            _balance = _balance + amount;            
        }
    }
}