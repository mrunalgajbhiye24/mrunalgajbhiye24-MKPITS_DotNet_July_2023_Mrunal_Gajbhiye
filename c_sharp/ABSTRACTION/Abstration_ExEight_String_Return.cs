using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration_Account_Details_Return_String
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;

        public abstract string deposit(int actno, int amount);

        public string showbalance()
        {
            return "Total Balance:- " + bal;
        }
    }
    class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "Amount Deposited Successfully Without Interest in Current Class";
        }
    }
    class Saving:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 1000;
            bal = bal + amount + interest;
            return "Amount Deposited Successfully With Interest In Saving Class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account No:- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount:- ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type (Current or Saving):- ");
            string acttype = Console.ReadLine();

            Account act = null;
            if(acttype=="Current")
            {
                act = new Current();
            }
            else if(acttype=="Saving")
            {
                act = new Saving();
            }
            Console.WriteLine();
            Console.WriteLine("!----Account Details----!");
            string res = act.deposit(actno, amt);
            Console.WriteLine("Account No Is:- " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
