using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTime_PolyMorphsim_Accepting_Type_Of_Account
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
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
            Console.WriteLine("---------[Current]---------");
            this.actno = actno;
            balance = balance + amount;
            return "Amount Deposited Successfully Without Interest In Current Class";
        }
    }

    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            Console.WriteLine();
            Console.WriteLine("---------[Savings]---------");
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
            Console.Write("Enter Account Type (Saving or Currrent):- ");
            String acttype = Console.ReadLine();


            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            String res = act.deposit(actno, amount);
            Console.WriteLine("Account No is:- " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }

    }
}

