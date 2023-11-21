using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExFour_Bank_account_Details_From_User
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
            bal = bal + amount + interest;
            Console.WriteLine("---------------------------------------");
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
    }
    class Current: Bank
    {
        int actno;
        int bal = 1000;

        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            bal = bal + amount;
            Console.WriteLine("---------------------------------------");
            return "Account No: " + actno + " " + "Total Balance is: " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = null;
            Console.Write("Enter Account No: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Type (Saving or Current): ");
            string acttype = Console.ReadLine();
            switch(acttype)
            {
                case "Saving":
                    b = new Saving();
                    break;
                case "Current":
                    b = new Current();
                    break;
            }
            string res = b.deposit(actno, amt);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
