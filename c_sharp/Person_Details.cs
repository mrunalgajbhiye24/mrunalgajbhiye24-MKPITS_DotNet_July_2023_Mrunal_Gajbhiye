using System;

namespace Person_Details
{
    internal class Program
    {
        class Person
        {
            string name;
            int age;
            string address;

            public void getdata(string name,int age,string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }

            public void displaydata()
            {
                Console.Write("Person Name: " + name+"\n");
                Console.Write("Person Age: " + age+"\n");
                Console.Write("Person Address: " + address);
            }
        }
        static void Main(string[] args)
        {
            Person per = new Person();
            per.getdata("Mrunal", 22, "Pl.No 115 Chandra Nagar,Nagpur");
            per.displaydata();
            Console.ReadKey();
        }
    }
}
