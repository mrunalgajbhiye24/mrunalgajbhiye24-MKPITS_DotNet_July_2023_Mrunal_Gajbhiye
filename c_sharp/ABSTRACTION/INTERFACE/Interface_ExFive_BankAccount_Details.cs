using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Interface_ExFive_Bank_Account_Details
{
    interface bank
    {
        string deposit(int actno, int amount);
    }
    class Account
    {
        public int actno;
        public int amount;
        public int bal = 1000;
    }
    class Saving:Account,bank
    {
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            int interest = 500;
            bal = bal + amount + interest;
            Console.WriteLine("--------------------------------------");
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
    }
    class Current : Account, bank
    {
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            Console.WriteLine("--------------------------------------");
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.Write("Enter Account No:- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount:- ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type (Saving Or Current):- ");
            string acttype = Console.ReadLine();

            switch(acttype)
            {
                case "Saving":
                    b = new Saving();
                    break;
                case "Current":
                    b = new Current();
                    break;
            }
            string res = b.deposit(actno, amt);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
