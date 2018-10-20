using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptions2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            if(b==0)//this program logicallException
            {
                Console.WriteLine("b value is dont give 0.u can choose any value");
            }
            else
            {
                c = a / b;
                Console.WriteLine("c value is:" + c);
            }
        }
    }
}
