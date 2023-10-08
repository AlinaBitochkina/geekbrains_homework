using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
            //645-> 5
            //78->третьей цифры нет
            //32679-> 6
            Console.WriteLine("Введите любое число");
            int number = Convert.ToInt32(Console.ReadLine());
            int number_2;
            if (number / 100 == 0)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else
            {
                while (number / 1000 != 0)
                {
                    number_2 = number / 10;
                    number = number_2;
                }
                int new_number = number % 10;
                Console.WriteLine("Третья цифра числа будет " + new_number);

            }

        }

    }
}
