using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TiasinIA.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                if ((x >= 3) && (x <= 3) && (y >= 5) && (y <= 10))
                {
                    return a = false;
                }
                if ((x >= 5) && (x <= 5) && (9 <= x) && (x <= 10) && (y == 13))
                {
                    return a = false;
                }
                if ((x == 12) && (y == 11))
                {
                    return a = false;
                }
                if ((x == 12) && (y >= 3) && (y <= 6))
                {
                    return a = false;
                }
                if ((x >= 6) && (x <= 10) && (y >= 3) && (y <= 5))
                {
                    return a = false;
                }

                return a;
            }
            else
            {
                return false;
            }
        }
    }
}
