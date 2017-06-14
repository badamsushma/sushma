using System;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {          
            int padlength = Math.Abs(args[0].Length - args[1].Length);
            string sp = new string('0', padlength);
            args[0] = (args[0].Length < args[1].Length) ? sp+args[0] : args[0];
            args[1] = (args[1].Length < args[0].Length) ? sp+args[1] : args[1];
            int max = (args[0].Length < args[1].Length) ? args[1].Length : args[0].Length;
            int[] p = new int[max];
            int[] q = new int[max];
            int i = 0;
            foreach (char ch in args[0].ToCharArray())
            {
                p[i] = Int32.Parse(ch.ToString());
                i++;
            }
            i = 0;
            foreach (char ch in args[1].ToCharArray())
            {
                q[i] = Int32.Parse(ch.ToString());
                i++;
            }
            Array.Reverse(p);
            Array.Reverse(q);
            int[] result = new int[max+1];
            int carry = 0;
            for ( i=0; i<max; i++)
            {
                int t = p[i] + q[i] + carry; 
                carry = t / 10;
                 result[i] = t % 10;
            }
            result[max] = carry;
            Array.Reverse(result);
            for(int j=0; j <= max; j++)
            {
                Console.Write(result[j]);
            }
        }
    }
}
