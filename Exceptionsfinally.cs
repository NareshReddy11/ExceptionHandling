using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptionsfinally
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}
