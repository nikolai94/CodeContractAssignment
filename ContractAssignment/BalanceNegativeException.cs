using System;
namespace ContractAssignment
{
    internal class BalanceNegativeException : Exception
    {
        public BalanceNegativeException() : base("test")
        {
        }
    }
}