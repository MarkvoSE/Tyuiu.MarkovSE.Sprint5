using Tyuiu.MarkovSE.Sprint5.Task2.V27.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint5\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;

            Assert.AreEqual(wait, fileExists);

        }
    }
}