using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using Tyuiu.ZamyatinKP.Sprint5.Task3.V2.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Спринт #5 | Выполнил: Замятин К. П. | ПИНб-25-1";
        Console.WriteLine(new string('*', 75));
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Замятин Кирилл Павлович | ПИНб-25-1                           *");

        var result = new DataService();

        string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";

        int x = 3;

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine(result.SaveToFileTextData(x).ToString());

        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            byte[] bytes = reader.ReadBytes(sizeof(double));
            double value = BitConverter.ToDouble(bytes, 0);
            Console.WriteLine(value.ToString());
        }

        Console.WriteLine(new string('*', 75));
        Console.ReadKey();
    }
}