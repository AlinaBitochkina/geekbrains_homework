using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            //9012-> 12
            Console.WriteLine("Введите любое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSumDigit(num));

            int GetSumDigit(int number) 
            {
                //int newNumber = number;
                int length = 0;
                int sum = 0;
                int newNum = number;
                while (newNum>0)      //цикл нахождения кол-ва цифр в числе            
                { 
                    newNum /= 10;
                    length++;
                }
                for (int i = 1; i <= length; i++) //цикл суммирования цифр в числе
                {
                    int digit = number % 10;
                    sum = sum + digit;
                    number = number / 10;                   
                }
                return sum;
            }
            
        }
    }
}
