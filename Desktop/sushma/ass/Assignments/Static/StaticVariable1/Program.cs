using System;
using StaticVariable2;
using System.Diagnostics;

namespace StaticVariable1
{
    class Program
    {
        static void Main(string[] args)
        {
           Process p = Process.Start(@"C:\Users\sushma.badam\Desktop\ass\StaticVariable2\bin\Debug\Net451\StaticVariable2.exe");
           Console.WriteLine("the static variable value : " + Program1.i);
           Program1.i = Program1.i+10;
           Console.WriteLine("after modifications value = " + Program1.i);
           Console.ReadLine();
        }
    }
}
