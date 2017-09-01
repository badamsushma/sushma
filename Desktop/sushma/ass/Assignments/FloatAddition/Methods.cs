using System;

namespace FloatAddition
{
   class Methods
    {
       public int IntToBinary(int number)
         {
              int quot;
              string rem = "";
              while (number >= 1)
              {
                  quot = number / 2;
                  rem += (number % 2).ToString();
                  number = quot;
              }
              string binary = "";
              for (int i = rem.Length - 1; i >= 0; i--)
              {
                  binary = binary + rem[i];
              }
              int n = Int32.Parse(binary);
              return n;
         }
          
       public string DecimalToBinary(double decimalValue) 
         {                          
             double i,j = 0.1;
             string arr = "";
             while( j > 0.001)       
               {
                  i = decimalValue*2;
                  arr += ((int)i).ToString(); 
                  j = j/10;
                  decimalValue = i - (int)i;  
               }
             return arr;
         }
        
       public int [] DecimalAddition(int Floattoint1, int Floattoint2)
         {
             int count = 0,size = 0,carry = 0;
             int[] result = new int[1000];
             while ( (Floattoint1 != 0) || (Floattoint2 != 0) )  
               {
                  result[count++] = (Floattoint1 % 10 + Floattoint2 % 10 + carry) % 2;
                  carry = ((Floattoint1  % 10 + Floattoint2 % 10 + carry) > 1) ? 1 : 0  ; 
                  Floattoint1 = Floattoint1 / 10;
                  Floattoint2 = Floattoint2 / 10;               
               }

             result[count++] = (carry != 0) ? carry : (carry = 0) ;
             int[] answer = new int[count];   
                
             while ( count > 0 )             
               {
                   answer[size] = result[--count]; 
                   size++;   
               }
             return answer;
         }   
      
       public int [] IntegerAddition(int convertedInteger1,int convertedInteger2,int carry)
         {            
             int count = 0, size = 0;
             int[] result = new int[1000]; 
             while ( (convertedInteger1 != 0) || (convertedInteger2 != 0) )
               {
                  result[count++] = (convertedInteger1 % 10 + convertedInteger2 % 10 + carry) % 2;
                  carry = ((convertedInteger1 % 10 + convertedInteger2 % 10 + carry) > 1) ? 1 : 0  ;
                  convertedInteger1 = convertedInteger1 / 10;
                  convertedInteger2 = convertedInteger2 / 10;                
               }
             result[count++] = carry != 0 ? carry : carry = 0 ;
            
             int[] answer = new int[count];        
             while ( count > 0 )                       
               {
                  answer[size] = result[--count]; 
                  size++;   
               }
             return answer;
         }

       public double BinaryToDouble(int[] result1,int[] result2)
         {
             int rem, ansI = 0, factor = 1, j = -1;
             for(int i = result2.Length-1; i >= 0; i--)              
               {
                  rem = result2[i] % 10;
                  ansI = ansI + rem * factor;
                  factor = factor * 2;   
               }
             rem = 0;
             double ansF = 0;
             for(int i = result1.Length-1; i >= 0; i--, j--)         
               {
                  rem = result1[i] % 10;
                  ansF = ansF + rem * Math.Pow(2,j); 
               }
             return (ansI + ansF);
         }
    }
}