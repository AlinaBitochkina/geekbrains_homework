using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int CheckIfEven(int number)

            {
                
                if (number % 2 == 0) Console.WriteLine("четное");
                else Console.WriteLine("нечетное");
                
                return number;
            }
            int num = 5;
            CheckIfEven(num);

        }
    }
}