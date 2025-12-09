using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyatinKP.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] nums = content.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string num in nums)
            {

                if (decimal.TryParse(num, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal number))
                {
                    
                    double Num = (double)number;
                    if (Num % 1 == 0)
                    {
                        if (Num >= 10 && Num <= 99)
                        {
                            sum += Num;
                        }
                    }
                    
                }
            }
            return sum;
        }
    }
}
