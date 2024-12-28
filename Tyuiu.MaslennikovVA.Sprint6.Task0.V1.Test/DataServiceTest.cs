using Tyuiu.MaslennikovVA.Sprint6.Task0.V1.Lib;

namespace Tyuiu.MaslennikovVA.Sprint6.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 0.2;
            Assert.AreEqual(wait, res);
        }
    }
}
