using Tyuiu.TiasinIA.Sprint2.Task4.V21.Lib;
namespace Tyuiu.TiasinIA.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;

            double res = ds.Calculate(x, y);
            double wait = 256;

            Assert.AreEqual(wait, res);
        }
    }
}