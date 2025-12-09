using System.Text;
using Tyuiu.ZamyatinKP.Sprint5.Task2.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Спринт #5 | Выполнил: Замятин К. П. | ПИНб-25-1";
        Console.WriteLine(new string('*', 75));
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");


        var result = new DataService();

        string path = $@"{Path.GetTempPath()}\OutPutFileTask2.csv";

        int[,] x = new int[3, 3];

        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                Console.Write($"Введите {j + 1}-ый (из 3) элемент {i + 1}-ой (из 3) строки массива: ");
                x[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(result.SaveToFileTextData(x).ToString());

        foreach (string line in File.ReadLines(path))
        {
            Console.WriteLine(line);
        }

        Console.WriteLine(new string('*', 75));
        Console.ReadKey();
    }
}