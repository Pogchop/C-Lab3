using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3ex1
{
    class Program
    {
        void printmessage(string message = "hello!")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string[] args)
        {
            Program opexample = new Program();
            opexample.printmessage("Welcome");
            opexample.printmessage();
            Console.ReadLine();
        }
    }
}
