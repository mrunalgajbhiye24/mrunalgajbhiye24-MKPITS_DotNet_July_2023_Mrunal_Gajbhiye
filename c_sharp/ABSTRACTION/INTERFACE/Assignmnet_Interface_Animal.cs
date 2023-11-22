using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_Interface_Animal
{
    interface IAnimal
    {
        string makesound(string sound);
    }
    class Dog:IAnimal
    {
        public string makesound(string sound)
        {
            return "Dog Sound:- " + sound;
        }
    }
    class Cat : IAnimal
    {
        public string makesound(string sound)
        {
            return "Car Sound:- " + sound;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal a;
            a = new Dog();
            string res = a.makesound("Bark...");
            Console.WriteLine(res);
            a = new Cat();
            string str = a.makesound("Meow Meow...");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
