using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipSample_01
{
    class Savings : Account
    {
        public Savings(string number, string customerName, double interestAmount) :base(number, customerName)
        {
            InterestAmount = interestAmount;
        }

        public double InterestAmount { set; get; }
    }
}
