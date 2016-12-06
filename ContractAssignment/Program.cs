using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //Console.WriteLine("divide : " + p.divide(6, -3));
            Account account = new Account();
            account.amount = 100;
            //Withdraw
            Console.WriteLine("Withdraw: "+ account.Withdraw(180.1));

            //Deposit
            //Console.WriteLine("Deposit: " + account.Deposit(90));

            Console.ReadKey();
        }

        /*public int divide(int a, int b)
        {
            Contract.Requires(b >= a);
            Contract.Ensures(Contract.Result<int>() * b == a);
            return a / b;
        }*/

    }
}
