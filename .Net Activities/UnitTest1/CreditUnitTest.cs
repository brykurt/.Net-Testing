using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreditAccountMain;


namespace CreditAccountTest
{
    //[TestClass]
    public class CreditAccountTestClass
    {
        double withdrew = 20000;
        DateTime expiration = DateTime.Now;
        bool isPaid = true;
       
     
        [TestMethod]
        public void Credit_DailyAmountLimit()
        {
            double withdrew1 = 30000;
            int counter = 3;
            double beginningBalance = 5000;
            
         
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter ,withdrew1 , expiration ,isPaid , 4000 );
            ba.AmountLimit(withdrew1);
        }

        [TestMethod]

        public void Credit_IsExpired() {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);

            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations ,isPaid,3000);
            ba.CheckExpiration(expirations);
        }

        [TestMethod]
        public void Credit_IsPaid() {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);
            bool isPaid1 = true;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations, isPaid1 , 3000);
            ba.CheckIfPaid(isPaid1);
            
        }

        [TestMethod]
        public void Credit_Interest()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);
            bool isPaid1 = true;
            
            double interest = 300;
            double payables = 2000 + interest;
            double paidtotal = 2300;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, counter, withdrew, expirations, isPaid1 , paidtotal);
           
            Assert.AreEqual(payables, paidtotal);
        }
        
        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentException()
        {
            int counter = 3;
            double beginningBalance = 5000;
            DateTime expirations = new DateTime(2020, 5, 20);
            

            double interest = 300;
            double payables = 2000 + interest;
            double paidtotal = 2300;
            double amount = 3000;
            CreditAccount ba = new CreditAccount("Bryon", beginningBalance, 2, withdrew, expiration, true , 4000);

            ba.Credit(amount);

        }




    }
}
