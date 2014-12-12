using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipSample_01
{
    class Account
    {
        public Account()
        {
            Balance = 0;
        }

        public Account(string number, string customerName) : this()
        {
            Number = number;
            CustomerName = customerName;
        }

        public string Number { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual string Withdraw(double amount)
        {
                Balance -= amount;
                return "withdrawn";
        }
    }
}
