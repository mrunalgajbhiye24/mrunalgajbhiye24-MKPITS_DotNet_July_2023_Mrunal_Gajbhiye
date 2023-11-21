using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ConsoleLogger
{
    interface ILogger
    {
        string Logmessage(string message);
        string LogError(string error_message);
    }
    class ConsoleLogger:ILogger
    {
        public string Logmessage(string message)
        {
            return "Message: " + message;
        }
        public string LogError(string error_message)
        {
            return "Error Message: " + error_message;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger l = null;
            l = new ConsoleLogger();
            string res = l.Logmessage("Message Delivered Successfully");
            Console.WriteLine(res);
            res = l.LogError("Some Error Occurs while delivering Message");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
