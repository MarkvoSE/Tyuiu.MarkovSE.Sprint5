using Tyuiu.MarkovSE.Sprint5.Task0.V20.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}