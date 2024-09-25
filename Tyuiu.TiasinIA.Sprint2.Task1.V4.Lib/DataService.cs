using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TiasinIA.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == 620) | (b < 0);
            res[1] = (a + 2 > b) & (c - 10 <= b);
            res[2] = (c > 9999) || (d != 414);
            res[3] = (a > 0) && ((d - 1000) > 0);
            res[4] = !((c & d) < 0);
            res[5] = (a - b < 0) ^ (c <= d);
            return res;
        }
    }
}
