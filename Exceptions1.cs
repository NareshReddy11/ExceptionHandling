using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptions1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a / b;
            Console.WriteLine("c value is:" + c);
        }
    }
}
/*
 * enter a, b values
12
0

Unhandled Exception: System.DivideByZeroException: Attempted to divide by zero.
   at ExceptionHandling.Exceptions1.Main(String[] args) in F:\c#.net\ExceptionHandling\ExceptionHandling\Exceptions1.cs:line 17
Press any key to continue . . .
*/
