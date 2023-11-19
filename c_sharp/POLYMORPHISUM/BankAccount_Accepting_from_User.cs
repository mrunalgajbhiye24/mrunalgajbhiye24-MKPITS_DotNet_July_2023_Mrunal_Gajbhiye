using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Accepting_From_User
{
    class Account
    {
        public int actno;
        public int bal = 1000;

        public virtual string deposit(int actno,int amount)
        {
            return "Deposit Method of Account Class";
        }
        public string showbalance()
        {
            return "Balance Amount: " + bal;
        }
    }
    class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            Console.WriteLine();
            this.actno = actno;
            bal = bal + amount;
            return "Amount Depsoited Successfully in Current Class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            Console.Write("Enter Account No: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            string res = act.deposit(actno, amount);
            Console.WriteLine("Account No Is: " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
