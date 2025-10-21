using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.MarkovSE.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            // Исправляем путь для Linux-системы
            string pathSaveFile = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask7.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!Char.IsUpper(line[i]))
                        {
                            strLine = strLine + line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}