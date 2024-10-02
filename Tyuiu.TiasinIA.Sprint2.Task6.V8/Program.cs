﻿using Tyuiu.TiasinIA.Sprint2.Task6.V8.Lib;
namespace Tyuiu.TiasinIA.Sprint2.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тясин И. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Тясин Илья Александрович | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:         *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число).                                *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите месяц:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string a;

            if ((n < 1) || (n > 12))
            {
                a = "Введенно неверное значение";
            }
            else
            {
                a = "Дата предыдущего дня - " + ds.FindDateOfPreviousDay(m, n);
            }
            if ((m < 1) || (m > 32))
            {
                a = "Введенно неверное значение";
            }
            else
            {
                a = "Дата предыдущего дня - " + ds.FindDateOfPreviousDay(m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
