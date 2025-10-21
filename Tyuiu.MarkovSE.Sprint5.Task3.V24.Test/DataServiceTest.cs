using Tyuiu.MarkovSE.Sprint5.Task3.V24.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            string filePath = ds.SaveToFileTextData(x);

            Assert.AreEqual(expectedPath, filePath);
            Assert.IsTrue(File.Exists(filePath));


            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Assert.AreEqual(169.89, result);
            }
        }

    }
}