using System;
using System.Collections.Generic;
namespace LegitBankApp.Model
{
    public class Admin : User
    {
        public string StaffID {get; set;}
    
        public Admin(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender): base (firstName,lastName,age,email,password,phoneNumber,address,gender)       
         {
            this.StaffID      = GenerateStaffID();
            this.FirstName    = firstName;
            this.LastName     = lastName;
            this.Age          = age;
            this.Email        = email;
            this.Password     = password;
            this.PhoneNumber  = phoneNumber;
            this.Address      = address;
            this.Gender       = gender;
            
         }


        public string GenerateStaffID()
            {
                var rand = new Random();
                string id = "ZENITH/ADMIN-"+rand.Next(0, 9).ToString()+rand.Next(50, 99).ToString()+"/" +FirstName[0]+FirstName[1]+FirstName[2]+rand.Next(0,9).ToString() ;
                return id;

            }

       


    }
}