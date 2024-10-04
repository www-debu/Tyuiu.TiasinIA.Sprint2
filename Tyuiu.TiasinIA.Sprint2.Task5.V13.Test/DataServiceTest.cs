using Tyuiu.TiasinIA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.TiasinIA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int g = 2020;
            int m = 10;
            int n = 23;

            Assert.AreEqual("24.10.2020 Год", ds.FindDateOfNextDay(g, m, n));
            

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2020, 10, 23);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(32, 13, 1989);
            });




           // if ((m == 2) && (n > 0) && (n < 29))
            //{
//n = n + 1;
          //  }
           // else
           // {
           //     Console.WriteLine("Число дня задано некорректно. Введите число от 1 до 31");
            }
    }
}