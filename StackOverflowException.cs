using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class StackOverflowException
    {
        static void recursion(int a)
        {
            Console.WriteLine(a);
            recursion(a+5);
        }
        static void Main(string[] args)
        {
            recursion(0);
        }
    }
}
