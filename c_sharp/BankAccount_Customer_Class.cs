using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Customer_Class
{
    class BankAccount
    {
        string CustomerName;
        int AccountNumber;
        int Balance;

        public void getdata(string CustomerName,int AccountNumber, int Balance)
        {
            this.CustomerName = CustomerName;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        public void display()
        {
            Console.Write("Customer Name: " + CustomerName+"\n");
            Console.Write("Customer Account Number: " + AccountNumber+"\n");
            Console.Write("Balance: " + Balance+"\n");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount();
            string name;
            int actnum;
            int balance = 1000;
            int amount;

            Console.Write("Enter Customer Name: " );
            name = Console.ReadLine();
            Console.Write("Enter Account Number: ");
            actnum =Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int deposite = balance + amount;
            int withdrawl = balance - amount;

            Console.WriteLine("-------------------------------");
            bank.getdata(name, actnum, balance);
            bank.display();
            Console.WriteLine("Deposited: " + deposite);
            Console.WriteLine("Withdrwal: " + withdrawl);
            Console.ReadKey();
        }
    }
}
