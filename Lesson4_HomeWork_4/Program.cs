using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HomeWork_4
{
    internal class Program
    {
        //рекурсивная функция, вычисляющая число Фибоначчи для заданного значения n
        public static long GetNumberFibonacci(int n)
        {
            return n > 1 ? GetNumberFibonacci(n - 1) + GetNumberFibonacci(n - 2) : n;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Урок 4, домашнее задание № 4");

            //
            Console.Write("Введите целое положительное число (или 0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n}-ый член последовательности Фибоначчи равен {GetNumberFibonacci(n)}");


            //
            Console.ReadLine();
        }
    }
}
