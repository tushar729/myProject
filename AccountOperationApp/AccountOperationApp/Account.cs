using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }

        public decimal Deposit(decimal amount)
        {
           return Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            return Balance -= amount;
        }

        public string Report()
        {
            return CustomerName + ", your account number: " + AccountNumber + " and it's balance: " + Balance + " taka";
        }
    }
}
