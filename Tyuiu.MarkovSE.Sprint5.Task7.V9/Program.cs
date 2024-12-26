using Tyuiu.MarkovSE.Sprint5.Task7.V9.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: ДОбавление тоговых проектов по спринту                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Марков Савелий Евгеньевич | ИСПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V7.txt (файл взять из       *");
            Console.WriteLine("* архива согласно вашему варианту.Создать папку в ручную С:\\DataSprint5\\*");
            Console.WriteLine("* и скопировать в неё файл) в котором есть набор символьных данных.       *");
            Console.WriteLine("* Удалить все заглавные латинские буквы из файла.                         *");
            Console.WriteLine("***************************************************************************");

            string[] path = { @"c:\DataSprint5", "InPutDataFileTask7V9.txt " };
            string pathFile = Path.Combine(path);

            string[] pathSaveFile = { @"c:\DataSprint5", "OutPutDataFileTask7V9.txt" };
            string fullPathSaveFile = Path.Combine(pathSaveFile);

            Console.WriteLine("Данные находятся в файле: " + pathFile);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Находится в файле: ");
            fullPathSaveFile = ds.LoadDataAndSave(pathFile);
            Console.WriteLine(fullPathSaveFile);


        }
    }
}