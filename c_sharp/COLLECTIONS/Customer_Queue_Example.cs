using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Customer_Queue_Example
{
    class Customer
    {
        public int id;
        public string name;
        public string email;
        public int mobileno;

        public Customer(int id, string name, string email, int mobileno)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.mobileno = mobileno;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "Amit", "amit267@gmail.com", 986545689);
            Customer c2 = new Customer(2, "Amar", "267amar@gmail.com", 923456789);
            Customer c3 = new Customer(3, "Ayush", "ayush22@gmail.com",983456788);

            Queue q = new Queue();
            q.Enqueue(c1);
            q.Enqueue(c2);
            q.Enqueue(c3);
            foreach (Customer c in q)
            {
                Console.WriteLine("Customer Id:- " + c.id);
                Console.WriteLine("Customer Name:- " + c.name);
                Console.WriteLine("Customer Email:- " + c.email);
                Console.WriteLine("Customer Mobile no:- " + c.mobileno);
                Console.WriteLine();
            }
            Customer r = (Customer)q.Dequeue();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Item Deque:" + " " + r.id + ":" + r.name + ":" + r.email + ":" + r.mobileno);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("After Deque");
            foreach (Customer c in q)
            {
                Console.WriteLine("Customer Id:- " + c.id);
                Console.WriteLine("Customer Name:- " + c.name);
                Console.WriteLine("Customer Email:- " + c.email);
                Console.WriteLine("Customer Mobile no:- " + c.mobileno);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
