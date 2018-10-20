using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public abstract class abstraction
    {
        public abstract void draw();
    }
    public class Rectangle : abstraction
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : abstraction
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            abstraction s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
        }
    }
}
