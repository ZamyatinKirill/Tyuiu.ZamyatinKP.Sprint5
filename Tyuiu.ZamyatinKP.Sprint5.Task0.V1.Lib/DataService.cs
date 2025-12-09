using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyatinKP.Sprint5.Task0.V1.Lib
{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, Math.Round((Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4), 3).ToString());
            return path;
        }
    }
}
