using System;

    public class Bank : Account
    {

        private string bankName;
        public Account[] accounts;

        public string BankName
        {
            set
            {
                this.bankName = value;
            }
            get
            {
                return this.bankName;
            }
        }
        public Bank(string bankName,int size)
        {
            this.bankName = bankName;
           this.accounts = new Account[5];
        }
        public void Addaccount(Account accountNo)         //add account
        {
            for(int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = accountNo;
                    break;
                }
            }

        }
        public void ShowAcountDetails(int accountNumber)     
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].accountNumber == accountNumber)
                {
                    accounts[i].Showaccouninfo();
                    break;
                }

            }

        }
        
        static void Main(string[] args)
        {
            Bank b1 = new Bank("Ashar Alo Bank", 5);
            Account a1 = new Account(0.00,101,"Anamul");
            Account a2 = new Account(0.00,102,"Haque");
            Address ob1 = new Address("10", "28", "Dhaka", "Bangladesh");
            Address ob2 = new Address("17", "27", "Dhaka", "Bangladesh");
            int boss=1;

            switch (boss)
            {
                 case 1:
                 {


            Console.WriteLine("\n");
            Console.WriteLine("*********************");
            Console.WriteLine("Enter open command to Open an account");
            Console.WriteLine("Enter account command to Perform transactions on an account");
            Console.WriteLine("Enter quit command to Exit the application");

            string menu = System.Console.ReadLine();  //converted
            Console.WriteLine("\n");
            Console.WriteLine("*********************");
            switch (menu) 
            {
                case "open":

                    Console.WriteLine("*********************");
                    Console.WriteLine("Enter savings command to Open a savings account");
                    Console.WriteLine("Enter cheking command to Open a cheking account");
                    Console.WriteLine("Enter quit command to Quit application");


                    string menu1 = System.Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("*********************");

                    switch (menu1)
                    {
                        case "savings":
                             Console.WriteLine("Open a saving account");

                             b1.Addaccount(a1);
                             b1.ShowAcountDetails(a1.accountNumber);
                             //Console.WriteLine("Address is: ");
                             //ob1.ShowAddress();

                            
                            break; 
                            

                        case "cheking":
                            Console.WriteLine("Open a cheking account");
                             b1.Addaccount(a1);
                             b1.ShowAcountDetails(a1.accountNumber);
                             
                            break;

                        case "quit":
                            Console.WriteLine("Quit application");
                             Environment.Exit(1);

                            break;
                        

                    }
                    break;

                case "account": //1

                    
                    Console.WriteLine("\n");
                    Console.WriteLine("*********************");

                    Console.WriteLine("Enter deposit command to Make a deposit");
                    Console.WriteLine("Enter withdraw command to Make a withdrawal");
                    Console.WriteLine("Enter transfer command to Make a transfer");
                    Console.WriteLine("Enter change command to Change owner name");
                    Console.WriteLine("Enter show command to Show the number transactions");
                    Console.WriteLine("Enter quit command to Exit the application");
                    
                    string menu2 = System.Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("*********************");

                    switch(menu2)
                    {
                        case "deposit":
                            
                            Console.WriteLine("Enter the amount to deposit money: ");
                            double amount = System.Convert.ToDouble(System.Console.ReadLine());
                            a1.Deposit(amount);
                            break;

                        case "withdraw":
                            
                            Console.WriteLine("Enter the amount to withdraw :");
                            double amount1 = System.Convert.ToDouble(System.Console.ReadLine());
                            a1.Withdraw(amount1);      //should be amount
                            break;
                        case "transfer":
                            Console.WriteLine("transfer");
                            Console.WriteLine("Enter the account to transfer money : ");
                            int accountReceiver = System.Convert.ToInt32(System.Console.ReadLine()); //to int

                            Console.WriteLine("Enter the amount you will transfer: ");
                            double money = System.Convert.ToDouble(System.Console.ReadLine());
                            a1.Transfer(accountReceiver, money);
                            break;

                        case "change":
                            Console.WriteLine("change");
                            Console.WriteLine("Your old name is  : "+ a1.accountName);
                            Console.WriteLine("Enter new name:");
                            a1.accountName=System.Console.ReadLine();
                            Console.WriteLine("Your new name is  : "+ a1.accountName);

                        
                            break;

                        case "show":
                            Console.WriteLine("show no of transaction");

                            break;

                        case "quit":
                            Console.WriteLine("quit");
                            Environment.Exit(1);

                        
                            break;


                    }
                    break;
    
                case "quit": //1
                    Console.WriteLine("quit");
                    Environment.Exit(1);

                    break;

                    
            }

                 }

                 goto case 1;
            
            }




            
        }
        
    }
