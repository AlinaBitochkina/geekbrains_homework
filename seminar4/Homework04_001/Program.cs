using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_001
{
    internal class Program
    {
        static void Main(string[] args)
        {//Напишите цикл, который принимает на вход два числа (A и B)
         //и возводит число A в натуральную степень B.
         //  3, 5-> 243(3⁵)
         // 2, 4-> 16
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;

            }
            Console.WriteLine(result);
            //Console.WriteLine(Math.Pow(a, b)); //можно использовать вместо цикла


        }   
        
    }
}

