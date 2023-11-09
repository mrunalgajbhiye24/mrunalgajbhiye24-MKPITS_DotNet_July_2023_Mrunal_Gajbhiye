using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Static_Field_Example
{
    class Account
    {
        public int accno;
        public string name;
        public static float rateofInterest = 8.8f;

        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void dispaly()
        {
            Console.WriteLine(accno + " " + name + " " + rateofInterest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101,"Mrunal");
            Account a2 = new Account(102, "Purvi");
            a1.dispaly();
            a2.dispaly();
            Console.ReadKey();
        }
    }
}
