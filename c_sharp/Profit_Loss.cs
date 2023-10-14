using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s, c, total;
            Console.Write("Enter Selling Price: ");
            s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Cost Price: ");
            c = Convert.ToInt32(Console.ReadLine());

            total = s - c;

            if (s > c)
                Console.WriteLine("Profit: "+total);
            else if (s < c)
                Console.WriteLine("Loss: "+total);
            else
                Console.WriteLine("No profit and loss");
            Console.ReadKey();

        }
    }
}
