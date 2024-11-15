﻿using Tyuiu.KorolevES.Sprint4.Task5.V11.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2. Заменить положительные    *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.Write("Введите количество строк в массиве: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[x, y];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++) 
                {
                    matrix[i, j] = rnd.Next(-7, 3);
                }
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = new int[x, y];
            res = ds.Calculate(matrix);
            Console.WriteLine("Массив после замены:");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
