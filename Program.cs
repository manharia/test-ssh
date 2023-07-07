using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication25
{
    class animal
    {
        protected double w;
        protected double h;
        protected static int l;
        public void info()
        {
            Console.WriteLine("weight" + w + "height" + h + "legs" + l);
        }
    }

    class Cat : animal
    {
        public Cat()
        {
            w = 500;
            h = 20;
            l = 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat Blackcat = new Cat();
            Blackcat.info();
            Console.ReadLine();
        }
    }
}