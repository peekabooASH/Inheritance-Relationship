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
            sv1.Withdraw(3000);

            Checking chk1 = new Checking("Chk-001", "Alvi", 7000);
            chk1.Deposit(4000);
            chk1.Withdraw(300);
            chk1.Withdraw(4000);

            Savings sv2 = new Savings("Sv-002", "Rana", 400);
            sv2.Deposit(2000);
            sv2.Withdraw(1800);

            Account anAccount = sv1;
            anAccount.Withdraw(10000);

            List<Account> accounts = new List<Account>();
            accounts.Add(sv1);
            accounts.Add(chk1);
            accounts.Add(sv2);

            WithdrawFromAll(accounts);

            Console.ReadKey();
        }

        public  static void WithdrawFromAll(List<Account> accountList)
        {
            foreach (Account anAccount in accountList)
            {
                Console.WriteLine(anAccount.Withdraw(100));
            }
        }

    }
}
