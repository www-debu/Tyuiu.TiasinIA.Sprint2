using Tyuiu.TiasinIA.Sprint2.Task3.V10.Lib;

namespace Tyuiu.TiasinIA.Sprint2.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.16;

            double res = ds.Calculate(x);

            Assert.AreEqual(res, wait);

        }
    }
}