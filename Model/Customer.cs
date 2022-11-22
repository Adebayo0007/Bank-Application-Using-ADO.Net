using System;
using System.Collections.Generic;
namespace LegitBankApp.Model
{
    public class Customer : User 
    {
        public string accountNumber {get; set;}
        public string pin           {get; set;}
        public string accountType   {get; set;}
        public int customerRegNum   {get; set;}
        public double accountBalance {get; set;}

        public Customer(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender,string pin,string accountType,double accountBalance) : base (firstName,lastName,age,email,password,phoneNumber,address,gender)
        {
            this.accountNumber = GenerateCustomerAcountNumber();
            this.pin = pin;
            this.accountType = accountType; 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            this.password = password;
            this.address = address;
            this.gender = gender;
            this.accountType = accountType;
            this.accountBalance = accountBalance;
        }

    

        public string GenerateCustomerAcountNumber()
            {
                Random random = new Random();
                Random rand = new Random();
                string preTest =customerRegNum.ToString();
                string customerAccountNumber = $"{random.Next(300,700).ToString()}{random.Next(100, 900).ToString()}{rand.Next(100,400).ToString()}0";
                return customerAccountNumber;

            }

       
    

    }
}