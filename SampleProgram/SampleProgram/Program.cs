using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sayHello();
            Console.WriteLine("Hello world");
            Console.WriteLine("Another line");
            Console.ReadLine();
        }
    }
}
