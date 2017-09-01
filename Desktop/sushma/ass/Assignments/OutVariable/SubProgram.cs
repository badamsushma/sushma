using System;

namespace OutVariable
{
    class SubProgram
    {
        public void Method(out int a,int b)
        {
               //Console.WriteLine(a);
               a = 20;
               Console.WriteLine(a+b);
        }
    }
}