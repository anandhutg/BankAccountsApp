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
    }
}
