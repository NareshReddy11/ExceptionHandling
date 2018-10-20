using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Exceptions3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a,bvalues");
            int c=0;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
            
                c = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            
            finally
            {
                Console.WriteLine("rest of the code");
            }
            Console.WriteLine("c value is :" + c);
        }
    }
}
/*
 enter a,bvalues
45
0
System.DivideByZeroException: Attempted to divide by zero.
   at ExceptionHandling.Exceptions3.Main(String[] args) in F:\c#.net\ExceptionHandling\ExceptionHandling\Exceptions3.cs:line 19
c value is :0
Press any key to continue . . .


 */
