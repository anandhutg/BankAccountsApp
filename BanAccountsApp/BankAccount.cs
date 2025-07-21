using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanAccountsApp
{
    internal class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        //Encapsulation of Balance Property
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Cannot deposit amount " + amount+"\n Enter valid amount!!";
            else if (amount > 20000)
                return "Deposit Limit Exceeded !!\n Enter valid amount!!";
            Balance += amount;
            return  "Deposited Amount :"+amount+" successfully!!\n Current Balance : "+Balance;

        }

        public string Withdraw(decimal amount)
        {
            if (amount > Balance)
                return "Insufficient Balance...!\n Current Balance :" + Balance;
            else if (amount <= 0)
                return "Cannot Withdraw amount " + amount + "\n Enter valid amount..!!";
            Balance -= amount;
            return "Withdrawn amount "+amount+" successfully!!\n Current Balance : "+Balance;
        }
    }
}
