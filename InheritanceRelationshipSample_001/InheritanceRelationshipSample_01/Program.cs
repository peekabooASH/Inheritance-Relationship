using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipSample_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings sv1 = new Savings("Sv-001", "Pulok", 9080);
            sv1.Deposit(3000);
            sv1.Withdraw(200);
            Console.WriteLine(sv1.Balance);

            Checking chk1 = new Checking("Chk-001", "Alvi", 7000);
            chk1.Deposit(4000);
            chk1.Withdraw(300);
            Console.WriteLine(chk1.Balance);

            Account acc2 = new Savings("sv028", "Salma", 786);
            Account acc3 = new Checking("chk-910" , "Kartik", 876);

            
            Savings sv3 = (Savings) new Account();


        }
    }
}
