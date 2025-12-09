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

            int sum = 0;

            foreach (string num in nums)
            {

                if (decimal.TryParse(num, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out decimal number))
                {
                    decimal rounded = Math.Round(number, 3);
                    
                    int intNum = (int)rounded;
                    if (intNum >= 10 && intNum <= 99)
                    {
                        sum += intNum;
                    }
                    
                }
            }
            return sum;
        }
    }
}
