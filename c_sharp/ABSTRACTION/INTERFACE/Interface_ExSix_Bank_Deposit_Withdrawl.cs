using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExSix_Bank_Deposit_Withdrawl
{
    interface bank
    {
        string deposit(int actno, int amount);
        string withdrawl(int actno, int amount);
    }
    class Account
    {
        public int actno;
        public int amount;
        public int bal = 1000;

        public string showbalance()
        {
            return "Total Balance:- " + bal;
        }
    }
    class Saving:Account,bank
    {
        public string deposit(int actno,int amount)
        {
            bal = bal + amount;
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
        public string withdrawl(int actno,int amount)
        {
            bal = bal - amount;
            Console.WriteLine("--------------------------------------");
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            b = new Saving();
            string str = b.deposit(123, 1000);
            Console.WriteLine(str);
            bank b1 = new Saving();
            str = b1.withdrawl(234, 500);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
