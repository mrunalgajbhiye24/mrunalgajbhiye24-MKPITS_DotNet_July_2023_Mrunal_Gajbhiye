using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Example_Override
{
    class Account
    {
        public int actno;
        public int bal = 1000;

        public virtual string deposite(int actno,int amount)
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
        public override string deposite(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "Amount Deposited Successfully in Current Class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            string res = act.deposite(123, 1000);
            Console.WriteLine("Account No is: " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
