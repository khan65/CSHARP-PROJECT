using System;

    public class Account : Address
    {
        public double currentBalance=0.0;
        public int accountNumber;
        public string accountName;

        public Account()
        {
            

        }


        public string AccountName
        {
            set
            {
                this.accountName = value;
            }
            get
            {
                return this.accountName;
            }
        }

        public int AccountNumber
        {
            set
            {
                this.accountNumber= value;
            }
            get
            {
                return this.accountNumber;
            }
        }

        public void Deposit(double amount)
        {
            
            currentBalance = currentBalance + amount;
            Console.WriteLine("Balnce: " + currentBalance);
        }

        public void Withdraw(double amount)
        {
            
            if (amount!=0 && amount>=500 && currentBalance >= amount)
            {
                currentBalance = currentBalance - amount;
                Console.WriteLine("You raised money: " + amount);
                Console.WriteLine("Your current balance is: " + currentBalance);
                
            }

            else
            {
                Console.WriteLine("The Balance is insufficient!!");
            }
        }

        public void Transfer(int accountReceiver, double money)
        {


            if (accountReceiver == AccountNumber)
            {
                currentBalance = currentBalance - money;
                Console.WriteLine("You have transferred money: " + money);
                Console.WriteLine("Your current balance is: " + currentBalance);


            }

            else
            {
                Console.WriteLine("Invalid account number!!");
            }
        }


        public Account(double currentBalance,int accountNumber,string accountName)
        {
            this.currentBalance=currentBalance;
            this.accountNumber=accountNumber;
            this.accountName=accountName;

        }

        public void Showaccouninfo()
        {
            Console.WriteLine("Current balance: " + currentBalance);
            Console.WriteLine("Account number: " +accountNumber);
            Console.WriteLine("Account name :" + accountName);
            

        }

    }

