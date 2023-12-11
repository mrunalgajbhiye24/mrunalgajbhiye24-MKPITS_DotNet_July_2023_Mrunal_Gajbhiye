using System;

namespace Hierarchicalexample
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }

    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }
    }


    public class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }
    }

    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }
    }


    public class Lion : Mammal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion Sounds Roar Roar!");
        }
    }

    public class Snake : Reptile
    {
        public Snake(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Snake sound Hiss Hiss!");
        }
    }

    public class Eagle : Bird
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Eagle sound Screech Screech!");
        }
    }

    class Program
    {
        static void Main()
        {

            // Create Instances of Different animal types
            Lion lion = new Lion("Simba", 5);
            Snake snake = new Snake("Nagini", 3);
            Eagle eagle = new Eagle("Thunder", 2);

            // Demonstrate Polymorphism by Calling the Common Method on Objects of Different Derived Classes
            Animal[] animals = { lion, snake, eagle };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }  
    
}
