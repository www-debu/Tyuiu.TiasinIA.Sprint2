﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TiasinIA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            
                string a;

                switch (n)
                {
                    case 1:
                        a = "01";
                        break;
                    case 2:
                        a = "02";
                        break;
                    case 3:
                        a = "03";
                        break;
                    case 4:
                        a = "04";
                        break;
                    case 5:
                        a = "05";
                        break;
                    case 6:
                        a = "06";
                        break;
                    case 7:
                        a = "07";
                        break;
                    case 8:
                        a = "08";
                        break;
                    case 9:
                        a = "09";
                        break;
                    case 10:
                        a = "10";
                        break;
                    case 11:
                        a = "11";
                        break;
                    case 12:
                        a = "12";
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");

                }
                if ((m > 1) && (m < 32))
                {
                    m = m - 1;
                }
                else
                {
                    Console.WriteLine("Число дня задано некорректно. Введите число от 2 до 31");
                }
                return m + "." + a;
    }   }
}
