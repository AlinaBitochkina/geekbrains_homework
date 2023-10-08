using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 15: Напишите программу, которая принимает на вход цифру,
            //обозначающую день недели, и проверяет, является ли этот день выходным.
            //6->да
            //7->да
            //1->нет

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            if (number > week.Length || number < 0)
            {
                Console.WriteLine("Такого дня недели не существует");
            }
            else
            {
                if (number == 6 || number == 7)
                {
                    Console.Write("Да, это выходной");
                }
                else
                {
                    Console.WriteLine("Нет, это не выходной");
                }
            }

        }
    }
}
