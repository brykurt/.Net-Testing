using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountMain;


namespace BankAccountTest
{
    //[TestClass]
    public class BankAccountTestClass
    {
        double withdrew = 20000;
        DateTime expiration;
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentException()
        {
            //arrange
            double beginningBalance = 5000;
            double amount = 4000;
            BankAccount ba = new BankAccount("Bryon", beginningBalance ,2 , withdrew , expiration);

            ba.Debit(amount);

        }
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 3000;
            double debitAmount = 1000;
            double expected = 4000;
            BankAccount ba = new BankAccount("Bryon", beginningBalance ,2 , withdrew , expiration);

            ba.Debit(debitAmount);

            Assert.AreEqual(expected, ba.Balance);
        } 

      

        [TestMethod]
        public void Debit_DailyWithdrawalLimit()
        {
            int counter = 3;
            double beginningBalance = 5000;
            BankAccount ba = new BankAccount("Bryon", beginningBalance,counter , withdrew , expiration );
            ba.WithdrawalLimit(counter);

            
        }

        [TestMethod]
        public void Debit_DailyAmountLimit()
        {
            double withdrew1 = 20000;
            int counter = 3;
            double beginningBalance = 5000;
            
         
            BankAccount ba = new BankAccount("Bryon", beginningBalance, counter ,withdrew1 , expiration );
            ba.AmountLimit(withdrew1);
        }

        [TestMethod]

        public void Debit_IsExpired() {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);

            BankAccount ba = new BankAccount("Bryon", beginningBalance, counter, withdrew, expirations);
            ba.CheckExpiration(expirations);
        }

       


    }
}
