using System;

namespace StaticVariable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1.Test();
           // Console.ReadLine();
            Program1.i = Program1.i + 10;
            Console.WriteLine(Program1.i);
            Console.ReadLine();
        }
    }
}
