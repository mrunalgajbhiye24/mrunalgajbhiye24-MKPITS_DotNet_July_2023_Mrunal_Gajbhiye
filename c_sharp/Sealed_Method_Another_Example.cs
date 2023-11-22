using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method_Another_Example
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void run()
        {
            Console.WriteLine("Running...");
        }
    }
    public class Dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating Bread...");
        }
        public sealed override void run()
        {
            Console.WriteLine("Running Very Fast");
        }
    }
    public class Babydog:Dog
    {
        public override void eat()
        {
            Console.WriteLine("Eating Biscuits");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog d = new Babydog();
            d.eat();
            d.run();
            Console.ReadKey();
        }
    }
}
