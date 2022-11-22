using System;
using LegitBankApp.Implementations;
using LegitBankApp.Interfaces;
using LegitBankApp.Model;

namespace LegitBankApp.Menu
{
    public class CustomerMenu : AdminMenu
    {

        IAdminManager _iAdminManager              = new AdminManager();
        ITransactionManager _iTransactionManager  = new TransactionManager();
        ICustomerManager _iCustomerManager         = new CustomerManager();
        public void AllCustomerMenu()
        {
              System.Console.WriteLine("\n\tEnter 1 to Register as Customer\n\tEnter 2 to Login Customer\n\tEnter 3 to see our Advert");
            int check;
            int.TryParse(Console.ReadLine(),out check);
            switch(check)
            {
                case 1:
                RegisterCustomerMenu();
                break;

                 case 2:
                LogCustomerMenu();
                break;

                case 3:
               var view = new ViewMenu();
               view.Ads();
                break;
            }
        }

        public void RegisterCustomerMenu()
        {
            Console.WriteLine(@"

 ################################################################################
 ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
 ####________________________________________________________________________####
 ####             Welcome to Zenith Bank >>> Admin Registration .            ####
 ####------------------------------------------------------------------------####
 ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
 ################################################################################");
            
            Console.WriteLine("\n\tHome && Register && Customer");
            Console.Write("\tEnter your First name: ");
            var firstName = Console.ReadLine();
            Console.Write("\tEnter your Last name: ");
            var lastName = Console.ReadLine();
            Console.Write($"\tHello {firstName} {lastName} ! \n\t Enter your age: ");
            var age = Console.ReadLine();
            Console.Write("\tEnter your email address: ");
            var email = Console.ReadLine().Trim().ToUpper();
            Console.Write("\tEnter your Password: ");
            var passWord = Console.ReadLine();
            Console.Write("\tEnter your Phone Number: ");
            var number = Console.ReadLine();
            Console.Write("\tEnter your Address: ");
            var address = Console.ReadLine();
            Console.Write("\tEnter your gender: ");
            var gender = Console.ReadLine();
            var customer = new Customer(" "," "," "," "," "," "," "," "," "," ",0);
            string pin;
            string accType;
             do
            {
            Console.Write("\tEnter four secrete digit Pin: ");
            pin = Console.ReadLine();
            }while(pin.Length != 4 );
            Console.Write("\tEnter your account type\n\tEnter 1 for Student account\n\tEnter 2 for Savings account\n\tEnter 3 for Current account\n\tEnter 4 for Business account\n\tEnter 5 for Joint account: ");
            int ch ;
            int.TryParse(Console.ReadLine(), out ch);
            if(ch ==1)
            {
                accType = "Student account";
                _iCustomerManager.CreateCustomer(firstName,lastName,age,email,passWord,number,customer.AccountNumber,gender,pin,accType);
            }

             if(ch ==2)
            {
                accType = "Savings account";
                _iCustomerManager.CreateCustomer(firstName,lastName,age,email,passWord,number,customer.AccountNumber,gender,pin,accType);
            }

             if(ch ==3)
            {
                accType = "Current account";
                _iCustomerManager.CreateCustomer(firstName,lastName,age,email,passWord,number,customer.AccountNumber,gender,pin,accType);
            }

             if(ch ==4)
            {
                accType = "Business account";
                _iCustomerManager.CreateCustomer(firstName,lastName,age,email,passWord,number,customer.AccountNumber,gender,pin,accType);
            }

             if(ch ==5)
            {
                accType = "Joint account";
                _iCustomerManager.CreateCustomer(firstName,lastName,age,email,passWord,number,customer.AccountNumber,gender,pin,accType);
            }

            Console.Write($"\n\t<<<<<-Congratulations !->>>>>\n\t<<<<<-Registration Completed->>>>> ");

            
            
            System.Console.WriteLine("\n\tEnter 1 to Login\n\tEnter 0 to opt out");
            int x;
            int.TryParse(Console.ReadLine(),out x);
            switch(x)
            {
                case 1:
               LogCustomerMenu();
                break;

                case 0:
                System.Console.WriteLine("Closing Application");
                break;
            }

            
        }

         public void LogCustomerMenu()
        {
             Console.WriteLine(@"

 ################################################################################
 ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
 ####________________________________________________________________________####
 ####             Welcome to Zenith Bank >>> Login Customer .                ####
 ####------------------------------------------------------------------------####
 ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
 ################################################################################");
            Console.WriteLine("\tWelcome !.\n\tEnter your E-mail and Password to login ");
            Console.Write("\tEnter your E-mail: ");
            var mail = Console.ReadLine();
            Console.Write("\tEnter your password: ");
            var pass = Console.ReadLine();
            var customer = _iCustomerManager.Login(mail,pass);
            if (customer != null)
            {
                Console.WriteLine($"Welcome {customer.FirstName } {customer.LastName}, you've successfully Logged in!");
                Console.WriteLine("\n\tEnter 0 to opt out\n\tEnter 1 to Make Transaction");
                int input;
                int.TryParse(Console.ReadLine(),out input);
                switch(input)
                {
                    case 0:
                    System.Console.WriteLine("Closong Application...");
                    break;

                    case 1:
                    SubCustomerMenuTransaction();
                    break;

                }
                
            }
            else
            {
                System.Console.Beep();
                Console.WriteLine("Wrong Input.");

                Console.WriteLine("\n\tEnter 1 to go back to login menu\n\tEnter 0 to 0pt out ");
                            int test; 
                            int.TryParse(Console.ReadLine(),out test);
                            if(test ==1 )
                                    {
                                           LogCustomerMenu();
                                    }
                            else
                                {
                                    System.Console.WriteLine("Closing...");
                                }
               
            }
        }


         public void SubCustomerMenuTransaction()
                    {
                          Console.WriteLine(@"

                        ################################################################################
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ####________________________________________________________________________####
                        ####                         Welcome To ZenithBank   !                      ####
                        ####------------------------------------------------------------------------####
                        ####>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>####
                        ################################################################################");
                        Console.WriteLine("\n\tHome >> Login >> Customer >>");
                        Console.WriteLine("\n\tEnter 0 to opt out\n\tEnter 1 to Create withdrawal\n\tEnter 2 to Create Deposit\n\tEnter 3 to Create airtime\n\tEnter 4 to Create Transfer");
                        int choice;
                        int.TryParse(Console.ReadLine(),out choice);
                        switch(choice)
                        {
                            case 0:
                            System.Console.WriteLine("Closing Application...");
                            break;
                            case 1:
                             CreateWithdrawalMenu();
                             Console.WriteLine("Enter 1 to go back to login menu");
                                int test; 
                                int.TryParse(Console.ReadLine(),out test);
                                if(test ==1 )
                                {
                                    LogInCustomer();
                                }
                                else
                                {
                                    System.Console.WriteLine("Closing...");
                                }
                            break;

                            case 2:
                            CreateDepositMenu();
                            Console.WriteLine("Enter 1 to go back to login menu");
                                int test1; 
                                int.TryParse(Console.ReadLine(),out test1);
                                if(test1 ==1 )
                                {
                                    LogInCustomer();
                                }
                                else
                                {
                                    System.Console.WriteLine("Closing...");
                                }
                            break;

                            case 3:
                            CreateAirtimeMenu();
                            Console.WriteLine("Enter 1 to go back to login menu");
                                int test2; 
                                int.TryParse(Console.ReadLine(),out test2);
                                if(test2 ==1 )
                                {
                                    LogInCustomer();
                                }
                                else
                                {
                                    System.Console.WriteLine("Closing...");
                                }
                            break;

                             case 4:
                             var admin = new AdminMenu();
                             admin.CreateTransferMenu();
                             Console.WriteLine("Enter 1 to go back to login menu");
                                int test3; 
                                int.TryParse(Console.ReadLine(),out test3);
                                if(test3 ==1 )
                                {
                                    LogInCustomer();
                                }
                                else
                                {
                                    System.Console.WriteLine("Closing...");
                                }
                            break;
                           
                        }

                    }












        
    }
}