using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExSeven_Bank_Details_Deposit_Withdrawl
{
    interface Bank
    {
        string deposit(int actno, int amount);
        string withdrawl(int actno, int amount);
        string showbalance();
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
        public int interest = 500;

    }
    class Saving : Account, Bank
    {

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount + interest;
            return "Account No: " + actno + " " + "Balance is : " + bal;
        }

        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "Account No: " + actno + " " + "Balance is : " + bal;
        }
        public string showbalance()
        {
            return "Account No: " + actno + " " + "Balance is : " + bal;
        }
    }

    class Current : Account, Bank
    {


        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "Account No " + actno + " " + "Balance is: " + bal;
        }
        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            bal = bal - amount;
            return "Account No " + actno + " " + " Balance is: " + bal;
        }
        public string showbalance()
        {
            return "Account No " + actno + " " + "Balance is: " + bal;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;

            Console.Write("Enter Account Type (Saving or current):- ");
            string acttype = Console.ReadLine();
            
            switch (acttype)
            {
                case "saving":
                    b = new Saving();
                    break;
                case "current":
                    b = new Current();
                    break;

            }
            Console.Write("Enter Transaction Type (deposit or withdrawl):- ");
            string tt = Console.ReadLine();

            string res = null;

            if (tt == "deposit")
            {
                res = b.deposit(123, 700);
            }
            else if (tt == "withdrawl")
            {
                res = b.withdrawl(567, 500);
            }
            Console.WriteLine(res);
            Console.WriteLine(b.showbalance());
            Console.ReadKey();

        }
    }
}

