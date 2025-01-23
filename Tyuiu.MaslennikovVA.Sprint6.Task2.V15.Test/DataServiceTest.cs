using Tyuiu.MaslennikovVA.Sprint6.Task2.V15.Lib;
namespace Tyuiu.MaslennikovVA.Sprint6.Task2.V15.Test
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
