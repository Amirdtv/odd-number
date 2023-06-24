using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fard
{
    class Fnumber
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { if (value > 0) { x = value; } }
        }
        public int Y
        {
            get { return y; }
            set { if (value > 0) { y = value; } }
        }
        public Fnumber() { }
        public Fnumber(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void odd()
        {
            for(int i = x ; i <= y ; i++ )
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(" number " + i + " odd ");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Fnumber f = new Fnumber(X,Y);
            f.odd();
            Console.ReadKey();
        }
    }
}
