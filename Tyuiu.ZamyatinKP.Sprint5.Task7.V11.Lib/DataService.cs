using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyatinKP.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string withoutSpaces = Regex.Replace(text, " ", "");

            string withoutLowercaseRussian = Regex.Replace(withoutSpaces, "[а-я]", "");

            File.WriteAllText(path, withoutLowercaseRussian);

            return path;
        }
    }
}
