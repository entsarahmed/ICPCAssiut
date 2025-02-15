using System;
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

            #region N. Char
            /*
              Console.WriteLine("Enter Your Character");
              char ch;
              bool Flag;
              do
              {
                  Flag= char.TryParse(Console.ReadLine(), out ch);
              }while(!Flag);

              if(ch >= 'a' && ch <= 'z')
                  Console.WriteLine(char.ToUpper(ch));
              else
                  Console.WriteLine(char.ToLower(ch));*/
            #endregion

            #region P. First digit !
            /*   Console.WriteLine("Enter Your Digit!");
               int X;
               int tens;
               bool Flag;
               do
               {
                   Flag = int.TryParse(Console.ReadLine(), out X);
                   // tens = X /10;
                   tens = Math.Abs((X / 1000) % 10);


               } while (!Flag);

               if (tens%2 == 0)
                   Console.WriteLine("EVEN");
               else
                   Console.WriteLine("ODD");
               Console.WriteLine(tens);*/

            #endregion

            #region Q. Coordinates of a Point

            /*  double X;
              double Y;
              bool Flag;

              do
              {
                  Console.WriteLine("Enter Your X");
                  Flag= double.TryParse(Console.ReadLine(), out X);
              } while (!Flag);
              do
              {
                  Console.WriteLine("Enter Your Y");
                  Flag = double.TryParse(Console.ReadLine(),out Y);
              }while (!Flag);*/

            /*  if (X > 0 && Y > 0)
                  Console.WriteLine("Q1");
              else if (X < 0 && Y > 0)
                  Console.WriteLine("Q2");
              else if (X < 0 && Y < 0)
                  Console.WriteLine("Q3");
              else if (X > 0 && Y< 0)
                  Console.WriteLine("Q4");
              else if (X ==  0 && Y == 0)
                  Console.WriteLine("Origem");
              else if (X != 0 && Y == 0)
                  Console.WriteLine("Eixo X");
              else
                  Console.WriteLine("Eixo Y");*/

            /*  string result = (X, Y) switch
              {
                  ( > 0, > 0) => "Q1",
                  ( < 0, > 0) => "Q2",
                  ( < 0, < 0) => "Q3",
                  ( > 0, < 0) => "Q4",
                  (0, 0) => "Origem",
                  (_, 0) => "Eixo X",
                  (0, _) => "Eixo Y",
                  _ => "Invalid" // This case should never happen, but it's a fallback.
              };
              Console.WriteLine(result);*/

            #endregion

            #region R. Age in Days
            /* Console.WriteLine("Enter Your Number Age for Days");
             int N;
             bool Flag;
             do
             {
                 Flag = int.TryParse(Console.ReadLine(),out N);
             }while(!Flag);

             int Years;
             int Month;
             int Days;

             Years = N / 365;
             Month = (N - Years *365) / 30;
             Days = (N - Years * 365 - Month*30);

             Console.WriteLine($"Years: {Years}");
             Console.WriteLine($"Month: {Month}");
             Console.WriteLine($"Days: {Days}");*/




            #endregion


            #region T. Sort Numbers
            /*
                        int A;
                        int B;
                        int C;
                        bool Flag;
                        do
                        {
                            Console.WriteLine("Enter Your A");
                            Flag = int.TryParse(Console.ReadLine(),out A);
                        }while(!Flag);
                        do
                        {
                            Console.WriteLine("Enter Your B");
                            Flag = int.TryParse(Console.ReadLine(), out B);
                        } while (!Flag);
                        do
                        {
                            Console.WriteLine("Enter Your C");
                            Flag = int.TryParse(Console.ReadLine(),out C);
                        }while (!Flag);

                        int GetMax = Math.Max(A, Math.Max(B, C));
                        int GetMin = Math.Min(A, Math.Min(B, C));   
                        int GetMid = (A + B + C) - (GetMax + GetMin);

                        Console.WriteLine($"{GetMin}\n{GetMid}\n{GetMax}");
                        Console.WriteLine($"{GetMax}\n{GetMid}\n{GetMin}");
                        */
            #endregion

            #region V. Comparison
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

            //if (A>B)
            //    Console.WriteLine("Right");
            //else if(A<B)
            //    Console.WriteLine("Wrong");
            //else
            //    Console.WriteLine("Right");

            #endregion

            #region X. Two intervals
            /*  int L1;
              int R1;
              int L2;
              int R2;
              bool Flag;

              do
              {
                  Console.WriteLine("Enter Your L1");
                  Flag = int.TryParse(Console.ReadLine(), out L1);
              } while (!Flag);
              do
              {
                  Console.WriteLine("Enter Your R1");
                  Flag = int.TryParse(Console.ReadLine(),out R1);
              }while (!Flag);
              do
              {
                  Console.WriteLine("Enter Your L2");
                  Flag = int.TryParse(Console.ReadLine(), out L2);
              }while (!Flag);
              do
              {
                  Console.WriteLine("Enter Your R2");
                  Flag = int.TryParse(Console.ReadLine(), out R2);
              } while (!Flag);
              if((L2 > R1 && R2 > R1) || (L2 < L1 && R2 < L1))
                  Console.WriteLine("-1");
              else
              {
                  int X,Y;
                  X= Math.Max(L1, L2);
                  Y= Math.Min(R1, R2);
                  Console.WriteLine($"{X } {Y}");
              }*/

            #endregion

            #region Y. The last 2 digits
           /* int A, B, C, D;
            bool Flag;
            do
            {
                Console.WriteLine("Enter Your A");
                Flag = int.TryParse(Console.ReadLine(), out A);
            } while (!Flag);
            do
            {
                Console.WriteLine("Enter Your B");
                Flag = int.TryParse(Console.ReadLine(), out B);
            }while (!Flag);
            do
            {
                Console.WriteLine("Enter Your C");
                Flag = int.TryParse(Console.ReadLine(), out C);
            } while (!Flag);
            do
            {
                Console.WriteLine("Enter Your D");
                Flag = int.TryParse(Console.ReadLine(),out D);
            }while(!Flag);

            int Result = A * B * C * D;
            int tens = Math.Abs((Result ) % 100);
            Console.WriteLine(tens);*/


            #endregion


        }

    }
}
