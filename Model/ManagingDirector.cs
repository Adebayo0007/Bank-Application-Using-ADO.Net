using System;
namespace LegitBankApp.Model
{
    public class ManagingDirector 
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string age     {get; set;}
        public string phoneNumber  {get; set;}
        public string managerId   {get; set;}

        public ManagingDirector(string firstName,string lastName,string age,string phoneNumber)
        {
            this.firstName   = firstName;
            this.lastName    = lastName;
            this.age         = age;
            this.phoneNumber = phoneNumber;
            this.managerId   = GenerateManagerID();
        }

         public string GenerateManagerID()
            {
                var rand = new Random();
                string id = "ZENITH/MANAGER-"+rand.Next(100, 500).ToString()+"/" +firstName[0]+firstName[1]+firstName[0]+"0" ;
                return id;

            }
    }
    
}