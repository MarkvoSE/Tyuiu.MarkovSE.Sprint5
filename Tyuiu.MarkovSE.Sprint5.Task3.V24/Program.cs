using Tyuiu.MarkovSE.Sprint5.Task3.V24.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Марков С.Е. | ИСПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Марков Савелий Евгеньевич | ИСПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить его значение при x = 2, результат сохранить в текстовый файл  *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль.                               *");
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Исходные данные
            int x = 3;
            Console.WriteLine("                               ИСХОДНЫЕ ДАННЫЕ                             ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Сохранение результата
                Console.WriteLine("                               РЕЗУЛЬТАТ:                                  ");
                Console.WriteLine("***************************************************************************");
                string filePath = ds.SaveToFileTextData(x);

                Console.WriteLine($"Файл: {filePath}");

                // Читаем содержимое бинарного файла
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    double result = reader.ReadDouble();
                    Console.WriteLine($"Результат: {result}");
                }

                Console.WriteLine("Файл успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}