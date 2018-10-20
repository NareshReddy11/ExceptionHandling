using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptions5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a, b values");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
             
                int b = Convert.ToInt32(Console.ReadLine());
                int c = 0;
           
                c = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
