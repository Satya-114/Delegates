using System;
using System.Collections.Generic;
using System.Text;

namespace Single_cast_1
{
    public delegate void mydele(int x, int y);

    class A
    {
        public void add(int x, int y)
        {
            Console.WriteLine("The Sum is " + (x + y));
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("The Difference is " + (x - y));
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            
            mydele m = new mydele(obj.add);
            m(10, 20);
            mydele m1 = new mydele(obj.sub);
            m1(10, 20);
        }
    }
}
