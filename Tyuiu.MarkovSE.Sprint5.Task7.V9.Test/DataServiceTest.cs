using Tyuiu.MarkovSE.Sprint5.Task7.V9.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string[] paths = { @"c:\DataSprint5", "OutPutDataFileTask7V9.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}