namespace LegitBankApp.Model
{
    public class User
    {
        public string FirstName {get;set;}
        public string LastName{get;set;}
        public string Age        {get;set;}
        public string Email      {get;set;}
        public string Password   {get;set;}
        public string PhoneNumber{get;set;}
        public string Address    {get;set;}
        public string Gender     {get;set;}

        public User(string firstName,string lastName,string age,string email,string password,string phoneNumber,string address,string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age        = age;
            this.Email      = email;
            this.Password   = password;
            this.PhoneNumber =phoneNumber;
            this.Address     = address;
            this.Gender      = gender;
        }


    }

}
