namespace LegitBankApp.Model
{
    public class User
    {
        public string firstName {get;set;}
        public string lastName{get;set;}
        public string age        {get;set;}
        public string email      {get;set;}
        public string password   {get;set;}
        public string phoneNumber{get;set;}
        public string address    {get;set;}
        public string gender     {get;set;}

        public User(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age        = age;
            this.email      = email;
            this.password   = password;
            this.phoneNumber =phoneNumber;
            this.address     = address;
            this.gender      = gender;
        }


    }

}
