using Tyuiu.MarkovSE.Sprint5.Task2.V27.Lib;
namespace Tyuiu.MarkovSE.Sprint5.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[,] matrix = new int[3, 3]
                {{1, 4, 3 },
             {1, 1, 4 },
             {4, 3, 8 },
                            };
                int rows = matrix.GetUpperBound(0) + 1;
                int columns = matrix.Length / rows;

                DataService ds = new DataService();
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
                Console.WriteLine("*                                                                         *");


                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Массив:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                string res = ds.SaveToFileTextData(matrix);
                Console.WriteLine("Файл " + res);
                Console.WriteLine("Создан!");
                Console.ReadKey();

            }
        }
    }
}