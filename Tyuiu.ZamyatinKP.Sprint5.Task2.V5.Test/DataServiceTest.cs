using Tyuiu.ZamyatinKP.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ZamyatinKP.Sprint5.Task2.V5.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.True(new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask0.txt").Exists);
        }
    }
}