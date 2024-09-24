using Tyuiu.TiasinIA.Sprint2.Task0.V24.Lib;

namespace Tyuiu.TiasinIA.Sprint2.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] prov = new bool[6] {true, true, false, false, true, true };
            CollectionAssert.AreEqual(prov, res);
        }
    }
}