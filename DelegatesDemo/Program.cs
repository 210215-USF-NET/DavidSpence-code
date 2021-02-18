using System;

namespace DelegatesDemo
{
    class Program
    {

        public delegate int Calc(int i, int j);

        public static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }
        static void Main(string[] args)
        {
            
            Calc c1 = new Calc(Add);
            Calc c2 = new Calc(Multiply);

            Console.WriteLine(c1(3,3));
            Console.WriteLine(c2(3,3));
        }
    }
}
