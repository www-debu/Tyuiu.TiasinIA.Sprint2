using Tyuiu.TiasinIA.Sprint2.Task0.V24.Lib;

namespace Tyuiu.TiasinIA.Sprint2.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тясин И.А. | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #2                                                               *");
            Console.WriteLine("* Тема : Операции сравнения                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Тясин Илья Александрович | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("*  выражений, которая вернет логическую последовательность(массив):       *");
            Console.WriteLine("*  (True, True, False, False, True, True), при x = 135, y = 755           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 135, y = 755                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 135;
            int y = 755;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
    
}
//