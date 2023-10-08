using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            PrintEvenNumbers(x);
        }
        static void PrintEvenNumbers(int n)
        {
            int i = 2;
            while (i <= n)
            {
                Console.Write($"{i} \t ");
                i += 2;
            }
        }
    }
}
