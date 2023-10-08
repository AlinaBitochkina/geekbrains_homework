using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //1, 2, 5, 7, 19, 6 , 1 , 33-> [1, 2, 5, 7, 19 , 6 , 1, 33]
            int[] array = new int[8];
            FillArray();

            //ВОПРОС ПРЕПОДАВАТЕЛЮ: ПОЧЕМУ ТО У МЕНЯ В VS не работает должным образом new Random().Next(1, 10)
            //код рабочий, но он выводит мне 8 раз одно и то же число, и каждый раз разное (8 раз цифру 5, или 8 раз цифру 4)
            //void FillArray()
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        array[i] = new Random().Next(1, 10);
            //        Console.WriteLine(array[i]);
            //    }
            void FillArray()
            {
                Random rnd = new Random(); // только так работает в VS рандомайзер, но не понимаю почему
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 10);
                    Console.Write(array[i]);
                }
            }



    }
    }
}
