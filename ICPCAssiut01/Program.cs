﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
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

            #region E. Area of a Circle
            //Area = π * R2.
            //Console.WriteLine("Enter Your R");
            //double R;
            //const double Pi = 3.141592653;
            //double Area;
            //bool Flag;
            //do
            //{
            //    Flag = double.TryParse(Console.ReadLine(), out R );
            //} while (!Flag);

            //Area = (Pi *  R * R);
            //Area=Math.Round(Area, 9);
            //Console.WriteLine(Area.ToString("0.000000000"));






            #endregion

            #region F. Digits Summation
            /*   Console.WriteLine("Enter Your First Number");
               int Num1;
               int Num01;
               Console.WriteLine("Enter Your Second Number");
               int Num2;
               int Num02;
               bool Flag;

               do
               {
                   Flag = int.TryParse(Console.ReadLine(), out Num1);

                   Num01 =Num1 % 10;
               } while (!Flag);
               do
               {
                   Flag = int.TryParse(Console.ReadLine(), out Num2);
                   Num02 =Num2 % 10;
               } while (!Flag);
               Console.WriteLine($"{Num01 + Num02} ");*/

            #region Get last or first Number
            //int num = 12;
            //int ones = num % 10;
            //int tens = num /10;
            //Console.WriteLine(ones);
            //Console.WriteLine(tens); 
            #endregion


            #endregion

            #region G. Summation from 1 to N

            //Console.WriteLine("Enter Your Number");

            //int Num01;
            //bool Flag;
            //int sum = 0;

            //do
            //{
            //    Flag = int.TryParse(Console.ReadLine(), out Num01);
            //    for (int i = 1; i<=Num01; i++)
            //        sum+=i;
            //} while(!Flag);
            //Console.WriteLine(sum);


            #endregion

            #region H. Two numbers

            /* Console.WriteLine("Enter your Number");
             double Num01;
             Console.WriteLine("Enter Your division Number");
             double DivNum;
             double FloorResult;
             double CeilResult;
             double RoundResult;
             bool Flag;
             do
             {
                 Flag =double.TryParse(Console.ReadLine(), out Num01);
             }while (!Flag);
             do
             {
                 Flag= double.TryParse(Console.ReadLine(),out DivNum);
             }while (!Flag);

             FloorResult = (Num01 /  DivNum);
             Console.WriteLine(Math.Floor(FloorResult));
             CeilResult = (Num01 / DivNum);
             Console.WriteLine(Math.Ceiling(CeilResult));
             RoundResult = (Num01 / DivNum);
             Console.WriteLine(Math.Round(RoundResult));*/
            #endregion

            #region I. Welcome for you with Conditions


            //int A;
            //int B;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Your A");
            //    Flag = int.TryParse(Console.ReadLine(), out A);
            //} while (!Flag);
            //do
            //{
            //    Console.WriteLine("Enter Your B");
            //    Flag = int.TryParse(Console.ReadLine(), out B);
            //}while (!Flag);

            //if(A >= B)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region J. Multiples


            /*  int A;
              int B;

              bool Flag;
              do
              {
                  Console.WriteLine("Enter Your A");
                  Flag = int.TryParse(Console.ReadLine(), out A);
              } while (!Flag);

              do
              {
                  Console.WriteLine("Enter Your B");
                  Flag = int.TryParse(Console.ReadLine(),out B);
              }while (!Flag);

              if((A%B) == 0)
                  Console.WriteLine("Multiples");
              else if((B%A) == 0)
                  Console.WriteLine("Multiples");
              else
                  Console.WriteLine("No Multiples");*/

            #endregion

            #region K. Max and Min

            /*    int A;
                int B;
                int C;
                bool Flag;

                do
                {
                    Console.WriteLine("Enter Your A");
                    Flag = int.TryParse(Console.ReadLine(), out A);
                } while (!Flag);
                do
                {
                    Console.WriteLine("Enter Your B");
                    Flag= int.TryParse(Console.ReadLine(),out B);
                }while (!Flag);
                do
                {
                    Console.WriteLine("Enter Your C");
                    Flag = int.TryParse(Console.ReadLine(), out C);
                }while(!Flag);
                if(A > B && A> C)
                {
                    Console.WriteLine(A);
                    if(B<C && B<A)
                    {
                        Console.WriteLine(B);
                    }
                    else
                    {
                        Console.WriteLine(C);
                    }
                }else if(B>A && B>C)
                {
                    Console.WriteLine(B);
                    if(C<B && C<A)
                    {
                       Console.WriteLine(C);
                    }
                    else
                    {
                        Console.WriteLine(A);
                    }
                }
                else
                {
                    Console.WriteLine(C);
                    if(A<B && A<C)
                    {
                        Console.WriteLine(A);
                    }
                    else
                    {
                        Console.WriteLine(B);
                    }
                }*/

            #endregion

            #region L. The Brothers
            /* Console.WriteLine("Enter Your First Name01");
             string F01 = Console.ReadLine()!;
             Console.WriteLine("Enter Your Second Name01");
             string  S01 = Console.ReadLine()!;
             string Person01 = F01 + " " + S01;
             Console.WriteLine(Person01);

             Console.WriteLine("Enter Your First Name02");
             string F02 = Console.ReadLine()!;
             Console.WriteLine("Enter Your Second Name02");
             string S02 = Console.ReadLine()!;
             string Person02 = F02 + " " + S02;
             Console.WriteLine(Person02);

             if (S01.Equals(S02))
                 Console.WriteLine("ARE Brothers");
             else
                 Console.WriteLine("NOT");*/
            #endregion

            #region M. Capital or Small or Digit

           /* Console.WriteLine("Enter the Char");
            char ch;
            bool Flag;
            do
            {
                Flag = char.TryParse(Console.ReadLine(), out ch);
            } while (!Flag);
            if (ch >= 'A' && ch <= 'Z')
                Console.WriteLine("ALPHA\r\nIS CAPITAL");
            else if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("ALPHA IS SMALL");
            else if(char.IsDigit(ch))
                Console.WriteLine("IS DIGIT");
            else
                Console.WriteLine( " is not an alphabetic character");*/
            #endregion


        }

    }
}
