using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method_BankAccount_Ex_Two
{
    abstract class Account
    {
        public abstract void deposit();
    }
    class Saving:Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello From Saving Deposit Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.deposit();
            Console.ReadKey();
        }
    }
}
