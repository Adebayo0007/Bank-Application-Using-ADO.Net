using System;
namespace LegitBankApp.Model
{
    public class ManagingDirector 
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Age     {get; set;}
        public string PhoneNumber  {get; set;}
        public string ManagerId   {get; set;}

        public ManagingDirector(string firstName,string lastName,string age,string phoneNumber)
        {
            this.FirstName   = firstName;
            this.LastName    = lastName;
            this.Age         = age;
            this.PhoneNumber = phoneNumber;
            this.ManagerId   = GenerateManagerID();
        }

         public string GenerateManagerID()
            {
                var rand = new Random();
                string id = "ZENITH/MANAGER-"+rand.Next(100, 500).ToString()+"/" +FirstName[0]+FirstName[1]+FirstName[0]+"0" ;
                return id;

            }
    }
    
}