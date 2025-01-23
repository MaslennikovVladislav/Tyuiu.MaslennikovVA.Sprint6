using Tyuiu.MaslennikovVA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.MaslennikovVA.Sprint6.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double wait = 70.14;
            Assert.AreEqual(wait, res[0]);
        }
    }
}
