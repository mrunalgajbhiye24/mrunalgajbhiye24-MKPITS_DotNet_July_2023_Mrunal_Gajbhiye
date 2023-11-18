using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_PolyMorphisum_Example_One
{
    class Baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("Hello From Base Class Show Method");
        }
    }
    class Childclass:Baseclass
    {
        public override void show()
        {
            Console.WriteLine("Hello From Child Class Show Mthod");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Baseclass b = new Childclass();
            b.show();
            Console.ReadLine();
        }
    }
}
