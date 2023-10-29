using System;
using System.Collections.Generic;
using System.Text;

namespace BMS
{
    abstract class Account
    {
        public readonly string name;
        public readonly string ID;
        public readonly DOB DOB;
        public readonly string nominee;
        public double balance;
        static string type =" Savings";
        public double ammount;
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);

        public double getBalance()
        {
            return balance;
        }
       public string getAccType(string type)
        {

            return type;
        }
        public void printAccount()
        {

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Date of Birth :" + DOB);
            Console.WriteLine("Nominee : " + nominee);
            Console.WriteLine("Balance :" + balance);
        }
        public Account()
        {

        }
        public Account(string name, DOB DOB, string nominee, double balance )
        {
            this.name = name;
            this.DOB = DOB;
            this.nominee = nominee;
            this.balance = balance;
          
        }
    }
}
