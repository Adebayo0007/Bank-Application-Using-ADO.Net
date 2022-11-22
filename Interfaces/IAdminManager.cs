using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface IAdminManager
    {
       void CreateAdmin (string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender);
       void UpdateAdmin (string firstName, string lastname, string phoneNumber,string age,string email,string password,string address,string adminRegNum);
       void DeleteAdmin (string id);
       Admin Login (string email, string passWord);
       Admin GetAdmin (string id);
       
        
    }
}