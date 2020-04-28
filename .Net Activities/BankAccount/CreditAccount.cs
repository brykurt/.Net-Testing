using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditAccountMain
{
    public class CreditAccount
    {
        private string _customerName;
        private double _balance;
        private int _dailyWithdrawalLimit;
        private double _dailyAmountLimit;
        private DateTime _cardExpiration;
        private bool _isPaid;
        private double _interestPaid;
        public CreditAccount(
            string customerName, 
            double balance, 
            int dailywithdrawalLimit, 
            double dailyamountLimit, 
            DateTime cardExpiration , 
            bool isPaid,
            double interestPaid)
        {
            _customerName = customerName;
            _balance = balance;
            _dailyWithdrawalLimit = dailywithdrawalLimit;
            _dailyAmountLimit = dailyamountLimit;
            _cardExpiration = cardExpiration;
            _isPaid = isPaid;
            _interestPaid = interestPaid;
        }

        public double Interest
        {
            get { return _interestPaid;  }
        }

        public double Balance
        {
            get { return _balance; }
        }
        public DateTime Expiration
        {
            get { return _cardExpiration; }
        }

        public bool Paid
        {
            get { return _isPaid; }
        }

     
        public void AmountLimit(double ctr)
        {
            if (ctr > 40000)
            {
                throw new ArgumentOutOfRangeException("daily withdrawal limit");
            }
            this._dailyAmountLimit += ctr;
        }

        public void CheckExpiration(DateTime expr)
        {
            if (expr == DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Renew your card");
            }


        }

        public void CheckIfPaid(bool paid) {
        if (paid == false)
            {
                throw new ArgumentOutOfRangeException("Payables aren't settled");
            }
        
        }

        public void Credit(double amount)
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




    }
}
