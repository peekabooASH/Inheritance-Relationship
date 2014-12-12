using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipSample_01
{
    class Checking : Account
    {
        public Checking(string number, string customerName, double serviceCharge) : base(number, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public double ServiceCharge { set; get; }
        public int NoOfTransactions { private set; get; }

        public override void Deposit(double amount)
        {
            NoOfTransactions++;
            base.Deposit(amount);
        }

        public override string Withdraw(double amount)
        {
            NoOfTransactions++;
            return base.Withdraw(amount);
        }
    }
}
