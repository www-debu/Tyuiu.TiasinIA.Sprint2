using Tyuiu.TiasinIa.Sprint2.Task5.V13.Lib;
namespace Tyuiu.TiasinIa.Sprint2.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тясин И.А. | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* спринт #2                                                               *");
            Console.WriteLine("* Тема : Вложенные операторы if - else                                    *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Тясин Илья Александрович | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение c              *");
            Console.WriteLine("* использованием тернарного оператора, где пользователь вводит            *");
            Console.WriteLine("* значение переменной X,У с клавиатуры. Округлить полученное значение     *");
            Console.WriteLine("* до трех знаков после запятой;                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int g = 0;
            int m = 0;
            int n = 0;


            Console.WriteLine("Введите год: ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день: ");
            n = Convert.ToInt32(Console.ReadLine());

            string a;

            if (g % 4 == 0)
            {

                if ((m < 1) || (m > 12))
                {
                    a = "Введенно неверное значение";
                }
                else
                {
                    a = "Дата следующего дня - " + ds.FindDateOfNextDay(g, m, n);
                }
                if ((n < 0) || (n > 32))
                {
                    a = "Введенно неверное значение";
                }
                else
                {
                    a = "Дата следующего дня - " + ds.FindDateOfNextDay(g, m, n);
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Следующим днем будет " + ds.FindDateOfNextDay(g, m, n));


            Console.ReadLine();
        }
    }
}
