using System.Text;
using Tyuiu.ZamyatinKP.Sprint5.Task6.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Спринт #5 | Выполнил: Замятин К. П. | ПИНб-25-1";
        Console.WriteLine(new string('*', 75));
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                      *");

        var result = new DataService();

        string x = "C:\\DataSprint5\\InPutDataFileTask6V25.txt";

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(result.LoadFromDataFile(x).ToString());

        Console.WriteLine(new string('*', 75));
        Console.ReadKey();
    }
}