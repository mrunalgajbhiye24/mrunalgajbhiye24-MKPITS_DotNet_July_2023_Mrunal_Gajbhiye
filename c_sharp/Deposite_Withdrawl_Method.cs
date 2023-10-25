using System;

namespace Depsoite_Withdrawl_Method
{
    internal class Program
    {
        static void account(int acntno,int amt)
        {
            int bal = 1000;
            int deposite;
            int withdrawl;   
            deposite = bal + amt;
            withdrawl = bal - amt;
            Console.WriteLine("Remaining Balance: " + deposite);
            Console.WriteLine("Remaining Balance: " + withdrawl);
        }
        static void Main(string[] args)
        {
            int actnum, amount;
            Console.Write("Enter ActNo: ");
            actnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            account(actnum, amount);
            Console.ReadKey();
        }
    }
}
