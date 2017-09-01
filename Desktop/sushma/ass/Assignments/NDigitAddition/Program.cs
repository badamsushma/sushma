using System;

namespace NDigitAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int differenceinLength = Math.Abs(args[0].Length - args[1].Length);
            string space = new string('0', differenceinLength);
            
            args[0] = (args[0].Length < args[1].Length) ? space+args[0] : args[0];
            args[1] = (args[1].Length < args[0].Length) ? space+args[1] : args[1];           
            
            int[] firstValue = new int[Math.Max(args[0].Length,args[1].Length)];
            int[] secondValue = new int[Math.Max(args[0].Length,args[1].Length)];
            
            int i = 0 ;
            foreach (char ch in args[0].ToCharArray())   {
                firstValue[i] = Int32.Parse(ch.ToString());
                i++;
                }
            
            i = 0;
            foreach (char ch in args[1].ToCharArray())  {
                secondValue[i] = Int32.Parse(ch.ToString());
                i++;   
                }
            
            Program1 p = new Program1();
            
            firstValue = p.Reverse(firstValue);
            secondValue = p.Reverse(secondValue);
            
            int[] answer = p.addition(firstValue,secondValue);
            answer = p.Reverse(answer);
            
            for(int j=0; j <= Math.Max(args[0].Length,args[1].Length); j++)
                {
                    Console.Write(answer[j]);
                }
        
        }
    }
}