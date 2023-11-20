using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Account_Example_Three
{
    abstract class Account
    {
        public abstract void deposit();

        public void showbalance()
        {
            Console.WriteLine("Balance Method");
        }
    }
    class Saving:Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving deposit Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.deposit();
            act.showbalance();
            Console.ReadLine();
        }
    }
}
