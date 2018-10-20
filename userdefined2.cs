using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class userdefined2:Exception
    {
        public userdefined2(string message) :base(message)
        {

        }
    }
    class userdefined22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b value");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            try
            {
                if(b%2>0)
                {
                    throw new userdefined2("b value don't give odd number");
                }
                else
                {
                  c = a / b;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("c value is:" + c);
            }
        }
    }
}
