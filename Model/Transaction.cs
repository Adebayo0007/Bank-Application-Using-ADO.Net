using System;
using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp
{
    public class Transaction 
    {
        public static double AccountBalance   {set; get;}
        public static double WithdrawalAmount {get; set;}
        public static double DepositAmount    {get; set;}
        public static double AirtimeAmount    {get; set;}
        public static string Accountnumber    {get; set;}
        public static string DateTime         {get; set;}
        public static double TransferAmount {get; set;}
        public  string RefNum                 {get; set;}
         public  static string Pin             {get; set;}
        
        public Transaction(double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountnumber1,string dateTime,string refNum,string pin) 
         {
           
            
            Transaction.AccountBalance = accountBalance;
            Transaction.WithdrawalAmount = withdrawalAmount;
            Transaction.DepositAmount = depositAmount;
            Transaction.AirtimeAmount = airtimeAmount;
            Transaction.DateTime      = dateTime;
            Transaction.Accountnumber = accountnumber1;
            Transaction.TransferAmount = transferAmount;
            Transaction.Pin = pin;
            refNum = this.RefNum;
            string alpha  ="abcdefghijklmnopqrstuvwxyz".ToUpper();
            var i = new Random().Next(25);
             var j = new Random().Next(25);
              var k = new Random().Next(25,99);
            this.RefNum        = $"Ref{k}{i}{j}{alpha[i]}{alpha[j]}" ;
          

            
         }

    }
}