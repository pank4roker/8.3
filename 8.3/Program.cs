using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8._3
{
    internal class Program
    {
               //task1
        /*public static void Func()
        {
            //task1
            for(int i=0;i<8;i++)
                Write("#");
            for (int j = 0; j < 2; j++)
                WriteLine(" ");
        }*/
               //task2
        public static void Func()
        {
            
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write("#");
                }
                WriteLine();
            }

        }
            
               //task3
       /* public static double Func(int a,int b)
        {
            return (a+Math.Sqrt(b))/(b+Math.Sqrt(a));
        }*/

        //task4
        /*public static int Min(int a, int b)
        {
            return (a > b) ? b : a;
        }*/

        static void Main(string[] args)
        {
                         //task1
            /*for (int i = 0; i < 4; i++)
            {
                Func();
            }*/
                         //task2
            Func();
                         //task3
            //Write($"y={Func(13,7)+Func(15,12)+Func(32,12):f2}");
                         //task4
            /*Write("Enter a: ");
            int a = Convert.ToInt32(ReadLine());
            Write("Enter b: ");
            int b = Convert.ToInt32(ReadLine());
            int z = Min(2 * a, b + a) + Min(2*a-b,b);
            Write(z);*/


            ReadKey();
        }
    }
}
