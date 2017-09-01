
using System;

namespace StaticVariable2
{
    public class Program1
    {
        public static int i = 10;
        public static void Test()
        {
            Console.WriteLine("Static variable value is : " + i);
            i++;
            Console.WriteLine("Static variable in test class : " + i);
        }
    }
}
