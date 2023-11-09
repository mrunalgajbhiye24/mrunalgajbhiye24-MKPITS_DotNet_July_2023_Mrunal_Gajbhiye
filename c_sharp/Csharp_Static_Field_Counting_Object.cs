using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Static_Field_Counting_Object
{
    class Account
    {
        public int accno;
        public string name;
        public static int count = 0;

        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void dispaly()
        {
            Console.WriteLine(accno + " " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Mrunal");
            Account a2 = new Account(102, "Purvi");
            Account a3 = new Account(103, "Rohini");
            Account a4 = new Account(104, "Aditi");
            a1.dispaly();
            a2.dispaly();
            a3.dispaly();
            a4.dispaly();
            Console.WriteLine("Total Objects Are: " + Account.count);
            Console.ReadKey();
        }
    }
}
