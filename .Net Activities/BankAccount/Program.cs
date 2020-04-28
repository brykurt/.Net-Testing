using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMain
{
    class BankAccountMain
    {
        static void Main(string[] args)
        {
            double beginningBalance = 4000;
            double amount = 1000;
            double withdrew = 20000;
            int counter = 2;
           
            BankAccount ba = new BankAccount("Bryon", beginningBalance , counter , withdrew ,DateTime.Now);

            ba.Debit(amount);
            
            Console.WriteLine("Your current balance is: {0}", ba.Balance);
            Console.WriteLine("Your withdrawal transaction is : {0}", ba.DailyWithdrawalLimit);
            Console.ReadLine();
        }
    }
}
