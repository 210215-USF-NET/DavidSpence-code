using System;

namespace DelegatesDemo2
{
    class Program
    {

        public delegate void MulticastDelegate(string s);

        public static void PrinterA(string s) {
            Console.WriteLine($"This is PrinterA method and this word {s} was passed in from the delegate");

        }

        public static void PrinterB(string s) {
            Console.WriteLine($"This is PrinterB method and this word {s} was passed in from the delegate");
        } 
        
        static void Main(string[] args)
        {
            MulticastDelegate mc;
            MulticastDelegate mc1 = new MulticastDelegate(PrinterA);
            MulticastDelegate mc2 = new MulticastDelegate(PrinterB);

            mc = mc1;
            mc += mc2;

            mc("TEST");
            
        }
    }
}
