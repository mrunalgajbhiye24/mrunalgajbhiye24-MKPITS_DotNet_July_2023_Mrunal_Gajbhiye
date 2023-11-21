using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExThree_Bank_Account
{
    interface Bank
    {
        string deposit(int actno, int amount);
    }
    class Saving:Bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            int interest = 500;
            bal = bal + amount+interest;
            return "Account No: " + actno +" "+ "Balance is: " + bal;
        }
    }
    class Current:Bank
    {
        int actno;
        int bal = 1000;

        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            return "Account No: " + actno + " " + "Balance is: " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            b = new Saving();
            string str = b.deposit(1, 700);
            Console.WriteLine(str);
            b = new Current();
            string res = b.deposit(2, 1000);
            Console.WriteLine(res);
            Console.ReadKey();
            

        }
    }
}
