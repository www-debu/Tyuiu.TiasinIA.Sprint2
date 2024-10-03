using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.TiasinIA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            

            if ((Math.Pow(x,2) - Math.Pow(y, 2) <= 0) && (y - x >= 0) && (y + x <= 0))
            {
                
            }
            return true;
        }
    }
}
