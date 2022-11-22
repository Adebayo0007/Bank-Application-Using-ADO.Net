using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface ICustomerManager
    {
        void CreateCustomer (string firstName,string lastName,string age,string email,string password,string phoneNumber,string accountNumber,string gender,string pin,string accountType);
        void UpdateCustomer (string firstName, string lastName,string age,string email,string password,string phoneNumber,string address, string pin,string accountType,string accountNumber);
        void DeleteCustomer (string accountNumber);
        Customer GetCustomer (string accountNumber);
        Customer Login(string email, string password);
      
             
    }
}