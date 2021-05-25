using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEX
{
    public delegate void mydele(int x, int y);

    class task
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
            task  b1 = new task  ();
            mydele Md = new mydele(b1.add);
            Md += b1.sub;
            Md(20, 10);


        }
    }
}