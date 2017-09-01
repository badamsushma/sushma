using System;

namespace NDigitAddition
{
    class Program1
    {
                
        public int [] Reverse(int [] value)
        {
            int [] tem =new int[value.Length];
            int m=0;
            for(int g=value.Length-1;g>=0;g--)
               {
                  tem[m]=value[g];
                  m++;
               }
            return tem;
        }
        public int [] addition(int [] value1,int [] value2)
        {
            int carry = 0;
            int[] result = new int[Math.Max(value1.Length,value2.Length)+1];
            for ( int i=0; i < Math.Max(value1.Length,value2.Length); i++)
              {
                 int t = value1[i] + value2[i] + carry; 
                 carry = t / 10;
                 result[i] = t % 10;    
              }
            result[Math.Max(value1.Length,value2.Length)] = carry;
            return result;
         }
        
    }
}
