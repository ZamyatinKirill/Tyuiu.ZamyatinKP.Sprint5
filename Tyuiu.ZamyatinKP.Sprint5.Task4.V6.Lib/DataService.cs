using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyatinKP.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));

            return Math.Round(1 / Math.Cos(x) + 2.2 * Math.Pow(x, 2), 3);
        }
    }
}
