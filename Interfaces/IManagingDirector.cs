using System.Collections.Generic;
using LegitBankApp.Model;
namespace LegitBankApp.Interfaces
{
    public interface IManagingDirector
    {
        void CreateManager(string firstName,string lastName,string age,string phoneNumber);
        void UpdateManager (string firstName, string lastName ,string phoneNumber,string managerId);
        ManagingDirector GetManager (string managerId);
        ManagingDirector LoginManager(string managerId);

    }
}