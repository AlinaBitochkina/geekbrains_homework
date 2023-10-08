using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_001
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            //456-> 5
            //782-> 8
            //918-> 1
            int number = new Random().Next(100,1000); 
            Console.WriteLine(number);
            int num1 = number / 100;
            int num2 = number - num1*100;
            int num3 = num2 / 10;
            Console.WriteLine(num3);
            


        }
    }
}
