using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTime_Polymorphism_Method_Overriding_Bank_Account
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "Deposit Method of Account Class";
        }
        public String showbalance()
        {
            return "Balance Amount : " + balance;
        }
    }

    class Current : Account
    {
      
        public override string deposit(int actno, int amount)
        {
            Console.WriteLine();
            Console.WriteLine("-----[Current]-----");
            this.actno = actno;
            balance = balance + amount;
            return "Amount Deposited Successfully Without Interest in Current Class";
        }
    }

    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            Console.WriteLine();
            Console.WriteLine("-----[Saving]-----");
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "Amount Deposited Successfully With Interest in Saving Class";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account No:- ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount to be Deposited:- ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account act = new Current();
            String res = act.deposit(actno, amount);
            Console.WriteLine("Account No is:- " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

            Console.WriteLine();
            Console.Write("Enter Account No:- ");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount to be Deposited:- ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            Account sav = new Saving();
            String res1 = sav.deposit(actno1, amount1);
            Console.WriteLine("Account No is:- " + sav.actno);
            Console.WriteLine(res1);
            res1 = sav.showbalance();
            Console.WriteLine(res1);
            Console.ReadKey();

        }
    }
}
