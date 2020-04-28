using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMain
{
    public class BankAccount
    {
        private string _customerName;
        private double _balance;
        private int _dailyWithdrawalLimit ;
        private double _dailyAmountLimit;
        private DateTime _cardExpiration;
        public BankAccount(string customerName, double balance, int dailywithdrawalLimit , double dailyamountLimit ,DateTime cardExpiration )
        {
            _customerName = customerName;
            _balance = balance;
            _dailyWithdrawalLimit = dailywithdrawalLimit;
            _dailyAmountLimit = dailyamountLimit;
            _cardExpiration = cardExpiration;
        }

        public DateTime Expiration
        {
            get { return _cardExpiration; }
        }

        public double Balance
        {
            get { return _balance; }

        }

        public int DailyWithdrawalLimit {
            get { return _dailyWithdrawalLimit; }
        }
      

        public void Debit (double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount > 0)
            {
                this._balance += amount;
            }
    

        }

     
        public void WithdrawalLimit(int counter)
        {
            if (counter > 3 )
            {
                throw new ArgumentOutOfRangeException("daily withdrawal limit");
            }
            this._dailyWithdrawalLimit  += counter;
            
        }

        public void AmountLimit(double ctr)
        {
            if (ctr > 20000)
            {
                throw new ArgumentOutOfRangeException("daily withdrawal limit");
            }
            this._dailyAmountLimit += ctr;
        }

        public void CheckExpiration (DateTime expr)
        {
            if (expr == DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Renew your card");
            }
         

        }

        


    }
}
