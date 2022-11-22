using System;
using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp
{
    public class Transaction 
    {
        public static double accountBalance   {set; get;}
        public static double withdrawalAmount {get; set;}
        public static double depositAmount    {get; set;}
        public static double airtimeAmount    {get; set;}
        public static string accountnumber    {get; set;}
        public static string dateTime         {get; set;}
        public static double transferAmount {get; set;}
        public  string refNum                 {get; set;}
         public  static string pin             {get; set;}
        
        public Transaction(double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountnumber1,string dateTime,string refNum,string pin) 
         {
           
            
            Transaction.accountBalance = accountBalance;
            Transaction.withdrawalAmount = withdrawalAmount;
            Transaction.depositAmount = depositAmount;
            Transaction.airtimeAmount = airtimeAmount;
            Transaction.dateTime      = dateTime;
            Transaction.accountnumber = accountnumber1;
            Transaction.transferAmount = transferAmount;
            Transaction.pin = pin;
            refNum = this.refNum;
            string alpha  ="abcdefghijklmnopqrstuvwxyz".ToUpper();
            var i = new Random().Next(25);
             var j = new Random().Next(25);
              var k = new Random().Next(25,99);
            this.refNum        = $"Ref{k}{i}{j}{alpha[i]}{alpha[j]}" ;
          

            
         }

    }
}