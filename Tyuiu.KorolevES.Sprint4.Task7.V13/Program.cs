using Tyuiu.KorolevES.Sprint4.Task7.V13.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка 159357246 из одноразрядных цифр. Преобразуйте ее в матрицу  *");
            Console.WriteLine("*  3 на 3 и подсчитайте количество четных чисел.                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string str = "159357246";
            int x = 3, y = 3,index =0;
            Console.WriteLine("Массив:");
            for (int i = 0; i<x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(str[index] + "\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(x, y,str);
            Console.WriteLine("Количество четных чисел в массиве:"+res);
            Console.ReadKey();
        }
    }
}
