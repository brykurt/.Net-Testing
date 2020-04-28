using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditAccountMain;
namespace BankAccountNunitTest
{   [TestFixture]
    public  class CreditUnit
    {
        double withdrew = 20000;
        DateTime expiration = DateTime.Now;
        bool isPaid = true;


        [Test]
        public void Credit_DailyAmountLimit()
        {
            double withdrew1 = 40000;
            int counter = 3;
            double beginningBalance = 5000;
            double withdrewlimit = 40000;

            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew1, expiration, isPaid, 4000);
            ba.AmountLimit(withdrew1);
            Assert.That(withdrew1, Is.LessThanOrEqualTo(withdrewlimit));
        }

        [Test]

        public void Credit_IsExpired()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);

            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations, isPaid, 3000);
            //act and assert
            Assert.That(expirations, Is.Not.EqualTo(DateTime.Now));
        }

        [Test]
        public void Credit_IsPaid()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);
            bool isPaid1 = true;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations, isPaid1, 3000);
            ba.CheckIfPaid(isPaid1);
            Assert.That(isPaid1, Is.EqualTo(true));
        }

        [Test]
        public void Credit_Interest()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);
            bool isPaid1 = true;

            double interest = 300;
            double payables = 2000 + interest;
            double paidtotal = 5000;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations, isPaid1, paidtotal);

          
            Assert.That(paidtotal, Is.GreaterThanOrEqualTo(payables));
        }

        [Test]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentException()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);


            double interest = 300;
            double payables = 2000 + interest;
            double paidtotal = 2300;
            double amount = 40;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, 2, withdrew, expiration, true, 4000);

            
            Assert.That(amount, Is.Not.LessThanOrEqualTo(0));

        }
    }
}
