using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZamyatinKP.Sprint5.Task2.V5.Lib
{
    public class DataService : ISprint5Task2V5
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    List<string> rowValues = new List<string>();

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] % 2 != 0)
                            rowValues.Add("0");
                        else
                            rowValues.Add(matrix[i, j].ToString());
                    }

                    writer.WriteLine(string.Join(";", rowValues));
                }
            }

            return path;
        }
    }
}
