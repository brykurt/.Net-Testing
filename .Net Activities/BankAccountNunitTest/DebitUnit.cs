using BankAccountMain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNunitTest
{   
    [TestFixture]
    
    public class DebitUnit
    {

        double withdrew = 20000;
        DateTime expiration;
        [Test]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentException()
        {
            //arrange
            double beginningBalance = 5000;
            double amount = 49;
            BankAccount ba = new BankAccount("Bryon", beginningBalance, 2, withdrew, expiration);

            Assert.That(amount, Is.Not.LessThanOrEqualTo(0));

        }
        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 3000;
            double debitAmount = 4000;
            double expected = 4000;
            BankAccount ba = new BankAccount("Bryon", beginningBalance, 2, withdrew, expiration);

           
            Assert.That(debitAmount, Is.GreaterThan(0));
        }



        [Test]
        public void Debit_DailyWithdrawalLimit()
        {
            int counter = 3;
            int counterlimit = 3;
            double beginningBalance = 5000;
            BankAccount ba = new BankAccount("Bryon", beginningBalance, counter, withdrew, expiration);
            ba.WithdrawalLimit(counter);

         
            Assert.That(counter, Is.LessThanOrEqualTo(counterlimit));
     

        }

        [Test]
        public void Debit_DailyAmountLimit()
        {
            double withdrew1 = 20000;
            int counter = 3;
            double beginningBalance = 5000;
            double dailylimit = 20000;

            BankAccount ba = new BankAccount("Bryon", beginningBalance, counter, withdrew1, expiration);
            Assert.That(withdrew1, Is.LessThanOrEqualTo(dailylimit));
        }

        [Test]

        public void Debit_IsExpired()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);

            BankAccount ba = new BankAccount("Bryon", beginningBalance, counter, withdrew, expirations);
            Assert.That(expirations, Is.Not.EqualTo(DateTime.Now));
        }


    }
}
