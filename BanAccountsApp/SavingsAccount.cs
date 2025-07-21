using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanAccountsApp
{
    //Inheritance Application
    public class SavingsAccount:BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner,decimal interestRate):base(owner+" ("+interestRate+"%)")
        {
           InterestRate = interestRate;
        }
        //Polymorphism
        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Cannot deposit amount " + amount + "\n Enter valid amount!!";
            else if (amount > 20000)
                return "Deposit Limit Exceeded !!\n Enter valid amount!!";
            decimal interestAmount = (InterestRate / 100) * (amount+Balance);
            Balance += amount+interestAmount;
            return "Deposited Amount :" + amount + " successfully!!\n Current Balance : " + Balance;

        }
    }
}
