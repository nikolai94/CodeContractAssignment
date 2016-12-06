using System;
using System.Diagnostics.Contracts;


namespace ContractAssignment
{
    internal class Account
    {
        public double amount { get; set; }
       
        public double Deposit(double value)
        {
            //the amount should increas, not decrease so no negative values
            Contract.Requires(value >= 0);
            //the result most be positive
            //Contract.Requires((this.amount+value) > 0);
            //Contract.Ensures(Contract.Result<double>() > 0);

            amount += value;
            return amount;
        }

        public double Withdraw(double value)
        {
            Contract.Requires(value >= 0);
            Contract.Ensures(amount >= 0);
            Contract.Ensures(amount == Contract.OldValue(amount) - value);

            // Contract.Ensures(Contract.Result<double>() >= 0);
            //Contract.EnsuresOnThrow<BalanceNegativeException>((this.amount - value) > 0);

            //Contract.Requires<ArgumentException>(this.amount > value, "amount");
            //Contract.EnsuresOnThrow<ArgumentException>(this.amount > 0);
            //Contract.Requires<ArgumentException>(amount > value, "test test");
            amount = (amount - value);
            return amount;
        }
    }
}