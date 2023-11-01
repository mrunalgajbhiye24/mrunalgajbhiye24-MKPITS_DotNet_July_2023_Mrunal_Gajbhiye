using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Class
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }

        public void displaydata()
        {
            Console.WriteLine("--Details of BankAccount of Customer--");
            Console.Write("Account Number: "+AccountNumber+"\n");
            Console.Write("Account Holder Name: "+AccountHolderName+"\n");
            Console.Write("Balance: "+Balance+"\n");
            Console.WriteLine();
        }
        public void transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }
        public void showbalance()
        {
            Console.WriteLine("Current Balance for account no {0} is {1} ", AccountNumber, Balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "Mrunal";
            b1.Balance = 1000;
            b1.displaydata();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "Purvi";
            b2.Balance = 500;
            b2.displaydata();

            b2.transfer(b1);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("balance after transaction ");
            Console.WriteLine("----------------------------------");

            b1.showbalance();
            b2.showbalance();

            Console.ReadKey();
        }
    }
}
