using System.Text;
using Tyuiu.ZamyatinKP.Sprint5.Task0.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Спринт #5 | Выполнил: Замятин К. П. | ПИНб-25-1";
        Console.WriteLine(new string('*', 75));
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");

        var result = new DataService();

        int x = 3;

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(result.SaveToFileTextData(x).ToString());

        Console.WriteLine(File.ReadAllText($@"{Path.GetTempPath()}\OutPutFileTask0.txt"));

        Console.WriteLine(new string('*', 75));
        Console.ReadKey();
    }
}