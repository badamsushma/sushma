using System;

namespace sushma
{
    class Program
    {
        static void Main(string[] args)
        {
           try{
            Console.WriteLine("enter first number");
            String num1 = Console.ReadLine();   
            int n = num1.Length;
            int[] p = new int[n]; 
            int j=0;
            foreach ( Char i in num1.ToCharArray() ) {
                p[j] = Int32.Parse(i.ToString());
                j++;
                }
                Console.Write("first number is : ");
                for ( int l=0; l < n ; l++)
                Console.Write(p[l]);
                Console.WriteLine();
            Console.WriteLine("enter second number");           
            String num2 = Console.ReadLine();
            int m = num2.Length;
             int[] q = new int[m]; 
             int k=0;
            foreach (char r in num2.ToCharArray() ) {
                q[k] = Int32.Parse(r.ToString());
                k++;
                }
                 Console.Write("second number is : ");
                for (int s=0; s < m; s++ )
                Console.Write(q[s]);
                Console.WriteLine();
                Array.Reverse(p);
                Array.Reverse(q);
                int x;
               if ( n < m )
               {
                    x = m;
               }
               else
               {
                    x = n;
               }
                    
                int[] result = new int[x+1];
                int carry = 0;
                for ( int i=0; i <x ; i++){
                    int y = carry+p[i] + q[i];
                    carry = y/10; 
                    y = y%10;
                    result[i] = y;
                }
                result[x] = carry;
                 Array.Reverse(result);
                for ( int i=0; i <= x; i++) {
                    Console.Write(result[i]);
                }
                }
           catch (Exception e){
               Console.WriteLine(e);

           }

        }
    }
}
