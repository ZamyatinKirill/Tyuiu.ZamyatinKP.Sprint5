using Tyuiu.ZamyatinKP.Sprint5.Task7.V11.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task7.V11.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.True(new FileInfo($@"{Path.GetTempPath()}\OutPutDataFileTask7V11.txt").Exists);
        }
    }
}