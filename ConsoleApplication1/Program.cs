using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            var a = 5;
            var b = 6;

            int number = Add(a);
        }

        private static int Add(int a)
        {
            int b = 7;
            return a + b;
        }
    }
}
