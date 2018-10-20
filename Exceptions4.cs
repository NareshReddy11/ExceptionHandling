using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptions4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the a, b values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            try
            {
                c = a / b;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.WriteLine("c value is:" + c);
        }
    }
}
