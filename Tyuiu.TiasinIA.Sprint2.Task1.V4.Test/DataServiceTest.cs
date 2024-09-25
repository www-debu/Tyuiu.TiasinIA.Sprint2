using Tyuiu.TiasinIA.Sprint2.Task1.V4.Lib;
namespace Tyuiu.TiasinIA.Sprint2.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}