using System;
using System.Threading;

namespace OutVariable
{
    class Program
      {
          static int x = 1;
          static void Main(string[] args)
          {
              Program p = new Program();   
              Thread thread = new Thread(p.Method1);
              thread.Start();
              Thread thread1 = new Thread(p.Method2);
              thread1.Start();
              //Console.WriteLine(p.x);
          }

        public void Method1()
        {
            int a = x;
            Increase(out a);
            Console.WriteLine(a);
        }
        public void Method2()
        {
            int a = x;
            Increase(a);
            Console.WriteLine(a);
        }
        public void Increase(out int i)
        {
            i = x;
            Console.WriteLine(i);
            i++;
        }
        public void Increase(int i)
        {
            i = x;
            Console.WriteLine(i);
            i++;
        }
    }
}
