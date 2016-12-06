using System;
using System.Diagnostics.Contracts;

public class Account
{
    private double amount;

    public double amount
    {
        get
        {
            return amount;
        }
        set
        {
            amount = value;
        }
    }

    public Account()
	{
	}

    public double Deposit(double value)
    {
        Contract.Requires(amount > value);
        amount += value;
        return amount;
    }

    public double Withdraw(double value)
    {
        //Contract.Requires(amount > value);
        Contract.Requires<ArgumentException>(amount > value, "test test");
        amount = (amount - value);
        return amount;
    }
}
