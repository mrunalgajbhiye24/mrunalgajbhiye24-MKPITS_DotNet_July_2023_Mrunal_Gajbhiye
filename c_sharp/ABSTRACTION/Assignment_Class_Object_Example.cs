using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Class_Obejct_Example
{
    class Person
    {
        public string name;
        public string address;
        public int age;

        public void getdata(string name,string address,int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public void displaydata()
        {
            Console.WriteLine("Person Name:- " + name);
            Console.WriteLine("Person Address:- " + address);
            Console.WriteLine("Person Age:- " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.getdata("Mrunal", "Pl.No 115 Chandra Nagar,Bhandara Road,Nagpur", 22);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
