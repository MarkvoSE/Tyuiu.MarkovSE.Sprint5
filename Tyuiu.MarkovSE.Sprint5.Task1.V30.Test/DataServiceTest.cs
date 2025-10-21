using Tyuiu.MarkovSE.Sprint5.Task1.V30.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\MarkovSe\source\repos\Tyuiu.MarkovSE.Sprint5\Tyuiu.MarkovSE.Sprint5.Task1.V30\bin\Debug\net8.0\outPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}