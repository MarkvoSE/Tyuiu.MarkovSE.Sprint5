using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MarkovSE.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        string alf = "abcdefghijklmnopqrstuvwxyz";
                        if ((alf.Count(x => x == line[i])) == 1)
                        {
                            count++;
                        }
                    }

                }
            }
            return count;
        }
    }
}