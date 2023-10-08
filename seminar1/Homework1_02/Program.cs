using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите первое число");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите третье число");
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max;
            //if (b > a && b > c)
            //{
            //    max = b;
            //}
            //else if (c > a && c > b)
            //{
            //    max = c;
            //}
            //else
            //    max = a;
            //Console.WriteLine(max);

            
         int Findmax(int a, int b, int c)

            {
                int result;
                if (b > a && b > c) result = b;
                else if (c > a && c > b) result = c;
                else result = a;
                return result;
            }
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int max = Findmax(num1, num2, num3);
            Console.WriteLine(max);
        }   

    }
}
