using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class outofboundException
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[7];

                for (int i= 0;i<=arr.Length;i++)
                {
                    arr[i] = i * i;
                }
                //arr[10] = 8;
                Console.WriteLine(arr[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
