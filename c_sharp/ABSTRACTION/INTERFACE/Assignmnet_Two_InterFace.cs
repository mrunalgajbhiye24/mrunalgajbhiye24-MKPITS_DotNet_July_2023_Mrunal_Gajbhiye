using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_Two_Interface
{
    interface IReadable
    {
        void readdata();
        string writedata(string writedata);
    }
    interface IWriteable
    {
        void readdata();
        string writedata(string writedata);
    }
    class Filehandler:IReadable,IWriteable
    {
        public void readdata()
        {
            Console.WriteLine("this is book");
        }
        public string writedata(string writedata)
        {
            return "Write Data ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Filehandler r;
            r = new Filehandler();

            r.readdata();
           
            string res = r.writedata("");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
