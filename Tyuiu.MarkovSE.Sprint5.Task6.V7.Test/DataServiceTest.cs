using Tyuiu.MarkovSE.Sprint5.Task6.V7.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task6.V7.Test
{
    [TestClass]
     public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 16;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}