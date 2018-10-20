using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
         : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter age");
                int num = Convert.ToInt32(Console.ReadLine());
                validate(num);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Rest of the code");
        }
    }
}