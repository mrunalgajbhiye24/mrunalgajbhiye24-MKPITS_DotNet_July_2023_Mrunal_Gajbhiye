using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_ExFive_Account_Details_Withdrawl_Or_Deposit
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;

        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);

        public void showbalance()
        {
            Console.WriteLine();
            Console.WriteLine("Total Balance:- "+ bal);
        }
    }
    class Saving:Account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;
        }
        public override void deposit(int amount)
        {
            int interest = 500;
            bal = bal + amount + interest;
            Console.WriteLine("Balance With Interest: " + bal);
        }
    }
    class Current:Account
    {
        public override void withdrawl(int amount)
        {
            bal = bal - amount;
        }
        public override void deposit(int amount)
        {
            bal = bal + amount;
            Console.WriteLine("Balance withount Interest: " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account Number:- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount:- ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type (Current Or Saving):- ");
            string acttype = Console.ReadLine();
            Console.Write("Enter Deposit Or Withdrawl:- ");
            string type = Console.ReadLine();

            Account act = null;
            if (acttype == "Saving")
            {
                act = new Saving();
            }
            else if (acttype == "Current")
            {
                act = new Current();
            }

            if (type == "deposit")
            {
                act.deposit(amt);
            }
            else if(type=="withdrawl")
            {
                act.withdrawl(amt);
            }
            act.showbalance();
            Console.ReadKey();
        }
    }
}
