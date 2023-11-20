using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_EXFour_Account_Details_From_User
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposit(int amount);

        public void showbalance()
        {
            Console.WriteLine();
            Console.WriteLine("--------Total Balance--------");
            Console.WriteLine("Balance Amount for Account No {0} is: {1} ", actno, bal);
        }
    }
    class Current:Account
    {
        public override void deposit(int amount)
        {
            bal = amount + bal;
        }
    }
    class Saving:Account
    {
        public override void deposit(int amount)
        {
            int interest = 500;
            bal = amount + bal + interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account No: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account Type (Current Or Saving): ");
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
            act.actno = actno;
            act.deposit(amt);
            act.showbalance();
            Console.ReadLine();
        }
    }
}
