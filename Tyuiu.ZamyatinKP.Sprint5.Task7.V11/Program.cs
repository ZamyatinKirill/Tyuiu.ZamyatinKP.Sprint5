using System.Text;
using Tyuiu.ZamyatinKP.Sprint5.Task7.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Спринт #5 | Выполнил: Замятин К. П. | ПИНб-25-1";
        Console.WriteLine(new string('*', 75));
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");

        var result = new DataService();

        string x = "C:\\DataSprint5\\InPutDataFileTask7V11.txt";

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(result.LoadDataAndSave(x).ToString());

        Console.WriteLine(File.ReadAllText($@"{Path.GetTempPath()}\OutPutDataFileTask7V11.txt"));

        Console.WriteLine(new string('*', 75));
        Console.ReadKey();
    }
}