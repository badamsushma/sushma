using System;

namespace FloatAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            string input1 = Console.ReadLine();
            Console.WriteLine("enter the second number");
            string input2 = Console.ReadLine();  

            double firstNumber = Convert.ToDouble(input1);
            double secondNumber = Convert.ToDouble(input2);
            
            int integralPart1 = (int)firstNumber;
            int integralPart2 = (int)secondNumber;
            
            double decimalPart1 = firstNumber - integralPart1;
            double decimalPart2 = secondNumber - integralPart2;
            
            Methods m = new Methods();
            
            //converting integers into binary values 
            int convertedInteger1 = m.IntToBinary(integralPart1); 
            int convertedInteger2 = m.IntToBinary(integralPart2);    

            //converting decimal values into binary    
            string floatArr1 = m.DecimalToBinary(decimalPart1);   
            string floatArr2 = m.DecimalToBinary(decimalPart2);  

            //decimal binary array converted into integer binary array
            int floattoInt1 = Int32.Parse(floatArr1);   
            int floattoInt2 = Int32.Parse(floatArr2);   
            
            //addition of two decimal numbers
            int[] floatResult = m.DecimalAddition(floattoInt1, floattoInt2);
            //addition of two integers
            int[] intResult = m.IntegerAddition(convertedInteger1, convertedInteger2,floatResult[0]); 
            
            //printing added binary number
            for (int c = 0; c < intResult.Length;c++){              
                Console.Write(intResult[c]);
            }
            Console.Write(".");
              for (int c = 0; c < floatResult.Length;c++){            
                Console.Write(floatResult[c]);
            }
            
            //converting binary number into float value
            double Answer = m.BinaryToDouble(floatResult,intResult);
            Console.WriteLine();
            Console.Write( Answer );
        }
    }
}