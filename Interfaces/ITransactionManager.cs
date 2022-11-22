using System;
using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface ITransactionManager
    {

        void CreateWithdrawal (double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountnumber2,string dateTime,string refNum,string pin);
        void CreateDeposit (double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountnumber2,string dateTime,string refNum,string pin);
        void CreateAirtime (double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string accountnumber2,string dateTime,string refNum,string pin);
        void DeleteTransaction (string refNum);
        void Transfer (double accountBalance,double withdrawalAmount,double depositAmount,double airtimeAmount,double transferAmount,string senderAccountnumber,string recieverAccountnumber,string dateTime,string refNum,string pin);
        Transaction GetTransaction (string refNum);
        
             
    }
}