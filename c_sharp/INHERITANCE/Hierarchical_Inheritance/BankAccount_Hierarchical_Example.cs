using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance_BankAccount_Example
{
    class Account
    {
        public int actno;
        public int bal = 1000;

        public void deposite(int amt)
        {
            Console.WriteLine("This is a Deposited Method of Account Class");
        }
    }
    class Saving:Account
    {
        public void deposite(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("Amount Deposited With Interest balance is:- " + bal);
        }
    }
    class Current : Account
    {
        public void deposite(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Amount Deposited Without Interest balance is:- " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.actno = 123;
            s.deposite(1000);

            Current c = new Current();
            c.actno = 234;
            c.deposite(500);
            Console.ReadKey();
        }
    }
}
