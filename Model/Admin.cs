using System;
using System.Collections.Generic;
namespace LegitBankApp.Model
{
    public class Admin : User
    {
        public string staffID {get; set;}
    
        public Admin(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender): base (firstName,lastName,age,email,password,phoneNumber,address,gender)       
         {
            this.staffID      = GenerateStaffID();
            this.firstName    = firstName;
            this.lastName     = lastName;
            this.age          = age;
            this.email        = email;
            this.password     = password;
            this.phoneNumber  = phoneNumber;
            this.address      = address;
            this.gender       = gender;
            
         }


        public string GenerateStaffID()
            {
                var rand = new Random();
                string id = "ZENITH/ADMIN-"+rand.Next(0, 9).ToString()+rand.Next(50, 99).ToString()+"/" +firstName[0]+firstName[1]+firstName[2]+rand.Next(0,9).ToString() ;
                return id;

            }

       


    }
}