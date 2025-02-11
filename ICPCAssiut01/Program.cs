using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ICPCAssiut01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A/ Given a name S. Print "Hello, (name)" without parentheses. Input Only one line containing a string S.  OutputPrint "Hello, " without quotes, then print name.

            /* Console.WriteLine("Enter Your Name");
             string S = Console.ReadLine()!;

             string Name = S.Insert(0, "Hello, ");

             Console.WriteLine(Name);*/

            #endregion


            #region B/ Only one line containing the following space-separated values: int, long long, char, float and double respectively.



            //Console.WriteLine("Enter Space-Separated values: int, long, char, float, double");

            //string[] input = Console.ReadLine().Split(' ');

            //int IntNumber;
            //bool Flag;
            //long LongNumber;
            //char charact;
            //float FloatNumber;
            //double DoubleNumber;


            //do
            //{
            //    Flag = int.TryParse(input[0], out IntNumber);
            //    Console.WriteLine(IntNumber);
            //}
            //while (!Flag);
            //do
            //{
            //    Flag = long.TryParse(input[1], out LongNumber);
            //    Console.WriteLine(LongNumber);
            //}while (!Flag);
            //do
            //{
            //    Flag = char.TryParse(input[2], out  charact);
            //    Console.WriteLine(charact);
            //}while (!Flag);

            //do
            //{
            //    Flag = float.TryParse(input[3],out FloatNumber);
            //    Console.WriteLine(FloatNumber);
            //}while(!Flag);

            //do
            //{
            //    Flag = double.TryParse(input[4], out DoubleNumber);
            //    DoubleNumber=Math.Round(DoubleNumber,2);
            //    Console.WriteLine(DoubleNumber);
            //} while (!Flag);




            #endregion


            #region C. Simple Calculator
            /*  Console.WriteLine("Enter Your First Number");
              double.TryParse(Console.ReadLine(), out double X);
              Console.WriteLine("Enter Your Second Number");
              double.TryParse(Console.ReadLine(), out double Y);

              Console.WriteLine("Enter Your Symbol : /, *, +, -");
              char.TryParse(Console.ReadLine(), out char Op);
              double Result;

              switch (Op)
              {
                  case '+':
                      Result = X + Y;
                      Console.WriteLine("Result: " + Result);
                      break;
                  case '-':
                      Result = X - Y;
                      Console.WriteLine("Result: " + Result);
                      break;
                  case '*':
                      Result = X * Y;
                      Console.WriteLine("Result: " + Result);
                      break;
                  case '/':
                      if(Y != 0)
                      {
                          Result = X / Y;
                          Console.WriteLine("Result: " + Result);
                      }
                      else
                      {
                          Console.WriteLine("Error: Division by zero is not allowed.");
                      }
                      break;
                  default:
                      Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                      break;

              }*/

            #endregion

            #region D. Difference
            //   X = (A * B) - (C * D)
            //Console.WriteLine("Enter Your A");
            //int A;
            //Console.WriteLine("Enter Your B");
            //int B;
            //Console.WriteLine("Enter Your C");
            //int C;
            //Console.WriteLine("Enter Your D");
            //int D;
            //double X;
            //bool Flag;


            //do
            //{
            //  Flag =  int.TryParse( Console.ReadLine(), out A);  
            //}while(!Flag);
            //do
            //{
            //   Flag = int.TryParse(Console.ReadLine(), out B);
            //}while(!Flag);
            //do
            //{
            //    Flag = int.TryParse(Console.ReadLine(), out C); 
            //} while (!Flag);
            //do
            //{
            //    Flag = int.TryParse(Console.ReadLine(), out D);
            //}while (!Flag);

            //Console.WriteLine("{4}=({0}*{1}) -({2}*{3})", A, B, C, D, X = (A * B) - (C * D));

            #endregion

        }

    }
}
